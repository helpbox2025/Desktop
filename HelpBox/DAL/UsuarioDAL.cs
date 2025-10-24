using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Data.SqlClient;
using HelpBox.Model; // Referencia a classe Usuario criada

namespace HelpBox.DAL
{
    public class UsuarioDAL
    {
        // Método para pegar a connection string do App.config
        private string GetConnectionString()
        {
            // Usa o nome "ConexaoBD" que você definiu no App.config
            string? connString = ConfigurationManager.ConnectionStrings["ConexaoBD"]?.ConnectionString;
            if (string.IsNullOrEmpty(connString))
            {
                throw new InvalidOperationException("A string de conexão 'ConexaoBD' não foi encontrada no App.config.");
            }
            return connString;
        }

        /// <summary>
        /// Verifica se o login (email) e senha correspondem a um usuário
        /// E se esse usuário também existe na tabela Tecnico.
        /// </summary>
        /// <returns>Objeto Usuario se for um técnico válido, null caso contrário.</returns>
        public Usuario VerificarLoginTecnico(string email, string senhaDigitada)
        {
            Usuario usuarioTecnico = null;
            string connectionString = GetConnectionString();

            // --- SEGURANÇA MUITO IMPORTANTE ---
            // Este exemplo compara senha em TEXTO PURO, o que é INSEGURO!
            // O ideal é: 1. Salvar HASH da senha no banco. 2. Comparar HASH aqui.
            // Use bibliotecas como BCrypt.Net para isso.
            string senhaParaComparar = senhaDigitada; // <- SUBSTITUIR por lógica de HASH!

            // Query para buscar o usuário pelo email e verificar a senha
            // E depois verificar se o ID existe na tabela Tecnico
            string sqlQuery = @"
                SELECT u.id_User, u.Nome_User, u.sobrenome_User, u.cargo_User, u.departamento_User, u.nivelAcesso_User
                FROM Usuario u
                INNER JOIN Tecnico t ON u.id_User = t.id_User 
                WHERE u.email_User = @Email AND u.senha_User = @Senha"; // <- COMPARAR HASH AQUI!

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                using (SqlCommand comando = new SqlCommand(sqlQuery, conexao))
                {
                    // Adiciona parâmetros de forma segura
                    comando.Parameters.AddWithValue("@Email", email);
                    comando.Parameters.AddWithValue("@Senha", senhaParaComparar); // <- USAR HASH AQUI!

                    try
                    {
                        conexao.Open();
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Se reader.Read() for true, encontrou um usuário que é técnico E a senha bateu
                            if (reader.Read())
                            {
                                // Cria o objeto Usuario com os dados encontrados
                                usuarioTecnico = new Usuario
                                {
                                    id_User = Convert.ToInt32(reader["id_User"]),
                                    email_User = email, // Já temos o email
                                    nome_User = reader["Nome_User"].ToString(),
                                    sobrenome_User = reader["sobrenome_User"]?.ToString(),
                                    cargo_User = reader["cargo_User"]?.ToString(), // Usar ? para campos que podem ser nulos no BD
                                    departamento_User = reader["departamento_User"]?.ToString(),
                                    nivelAcesso_User = Convert.ToInt32(reader["nivelAcesso_User"])
                                };
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        Console.WriteLine($"Erro SQL ao verificar técnico: {ex.Message}");
                        // Tratar erro (log, etc.) - pode lançar exceção para BLL
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro inesperado: {ex.Message}");
                        // Tratar erro
                    }
                } // Comando é finalizado aqui
            } // Conexão é finalizado aqui

            return usuarioTecnico; // Retorna o objeto Usuario (se for técnico válido) ou null
        }
    }
}
