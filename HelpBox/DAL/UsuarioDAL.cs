using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using System.Configuration;
using Microsoft.Data.SqlClient;
using HelpBox.Model;

namespace HelpBox.DAL
{
    public class UsuarioDAL
    {
        // Recupera a string de conexão do arquivo de configuração (App.config).
        private string GetConnectionString() 
        {
            // Usa o nome "ConexaoBD" que  definimos no App.config
            string? connString = ConfigurationManager.ConnectionStrings["ConexaoBD"]?.ConnectionString;
            if (string.IsNullOrEmpty(connString))
            {
                throw new InvalidOperationException("A string de conexão 'ConexaoBD' não foi encontrada no App.config.");
            }
            return connString;
        }

        // Verifica no banco de dados se o email pertence a
        // um técnico e valida a senha usando hash.
        public Usuario VerificarLoginTecnico(string email, string senhaDigitada) 
        {
            Usuario usuarioTecnico = null;
            string connectionString = GetConnectionString();

            string sqlQuery = @"
        SELECT u.id_User, u.Nome_User, u.sobrenome_User, u.cargo_User, 
               u.departamento_User, u.nivelAcesso_User, u.senha_User 
        FROM Usuario u
        INNER JOIN Tecnico t ON u.id_User = t.id_User 
        WHERE u.email_User = @Email"; 

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                using (SqlCommand comando = new SqlCommand(sqlQuery, conexao))
                {
                    // Adiciona parâmetros de forma segura
                    comando.Parameters.AddWithValue("@Email", email);


                    try
                    {
                        conexao.Open();
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Se reader.Read() for true, encontrou um usuário
                            // que é técnico E a senha bateu
                            if (reader.Read())
                            {

                                // Pega o HASH da senha que está armazenado no banco.
                                string hashSenhaDoBanco = reader["senha_User"].ToString();

                                // Usa .Trim() , para remover espaços extras.
                                string hashBDLimpo = hashSenhaDoBanco.Trim();

                                // Verifica se a senha digitada corresponde ao hash do banco.
                                bool senhaCorreta = false;
                                try
                                {
                                    // A função BCrypt.Verify faz a comparação segura.
                                    senhaCorreta = BCrypt.Net.BCrypt.Verify(senhaDigitada, hashBDLimpo);
                                }
                                catch (Exception exHash)
                                {
                                    Console.WriteLine($"Erro ao verificar hash BCrypt: {exHash.Message}");
                                    senhaCorreta = false; 
                                    // Garante que o login falhe se o hash for inválido
                                }
                                if (senhaCorreta)
                                {
                                  
                                    usuarioTecnico = new Usuario
                                    {
                                        id_User = Convert.ToInt32(reader["id_User"]),
                                        email_User = email,
                                        nome_User = reader["Nome_User"].ToString(),
                                        sobrenome_User = reader["sobrenome_User"]?.ToString(),
                                        cargo_User = reader["cargo_User"]?.ToString(), 
                                        // Usar ? para campos que podem ser nulos no BD
                                        departamento_User = reader["departamento_User"]?.ToString(),
                                        nivelAcesso_User = Convert.ToInt32(reader["nivelAcesso_User"])
                                    };
                                }                           
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine($"Erro SQL ao verificar técnico: {ex.Message}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro inesperado: {ex.Message}"); 
                        // Tratar erro
                        
                    }
                } 
            } 

            return usuarioTecnico; 
            // Retorna o objeto Usuario (se for técnico válido) ou null
        }
    }
}
