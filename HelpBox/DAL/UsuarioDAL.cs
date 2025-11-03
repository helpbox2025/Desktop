using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
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

            // ---- INÍCIO DA ALTERAÇÃO (BCrypt) ----
            // REMOVIDO: A variável 'senhaParaComparar' não é mais necessária, a verificação é feita abaixo.
            // string senhaParaComparar = senhaDigitada; // <- SUBSTITUIR por lógica de HASH!
            // ---- FIM DA ALTERAÇÃO ----

            // Query para buscar o usuário pelo email e verificar a senha
            // E depois verificar se o ID existe na tabela Tecnico

            // ---- INÍCIO DA ALTERAÇÃO (BCrypt) ----
            // MODIFICADO: A query agora busca também o campo 'senha_User' (que contém o hash)
            // e NÃO compara mais a senha na cláusula WHERE.
            string sqlQuery = @"
        SELECT u.id_User, u.Nome_User, u.sobrenome_User, u.cargo_User, 
               u.departamento_User, u.nivelAcesso_User, u.senha_User 
        FROM Usuario u
        INNER JOIN Tecnico t ON u.id_User = t.id_User 
        WHERE u.email_User = @Email"; // MODIFICADO: Cláusula "AND u.senha_User = @Senha" REMOVIDA.
                                      // ---- FIM DA ALTERAÇÃO ----

            using (SqlConnection conexao = new SqlConnection(connectionString))
            {
                using (SqlCommand comando = new SqlCommand(sqlQuery, conexao))
                {
                    // Adiciona parâmetros de forma segura
                    comando.Parameters.AddWithValue("@Email", email);

                    // ---- INÍCIO DA ALTERAÇÃO (BCrypt) ----
                    // REMOVIDO: O parâmetro @Senha não é mais usado na query SQL.
                    // comando.Parameters.AddWithValue("@Senha", senhaParaComparar); // <- USAR HASH AQUI!
                    // ---- FIM DA ALTERAÇÃO ----

                    try
                    {
                        conexao.Open();
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Se reader.Read() for true, encontrou um usuário que é técnico E a senha bateu
                            // MODIFICADO (BCrypt): Agora, 'reader.Read()' significa apenas que o TÉCNICO FOI ENCONTRADO.
                            if (reader.Read())
                            {
                                // ---- INÍCIO DA ALTERAÇÃO (BCrypt) ----
                                // ADICIONADO: Lógica de verificação do HASH BCrypt

                                // 1. Pega o HASH da senha que está armazenado no banco.
                                string hashSenhaDoBanco = reader["senha_User"].ToString();

                                // 2. (Segurança) Usa .Trim() como seu amigo, para remover espaços extras.
                                string hashBDLimpo = hashSenhaDoBanco.Trim();

                                // 3. Verifica se a senha digitada corresponde ao hash do banco.
                                bool senhaCorreta = false;
                                try
                                {
                                    // A função BCrypt.Verify faz a comparação segura.
                                    senhaCorreta = BCrypt.Net.BCrypt.Verify(senhaDigitada, hashBDLimpo);
                                }
                                catch (Exception exHash)
                                {
                                    // ADICIONADO: Loga um erro se o hash no banco for inválido
                                    // (Ex: uma senha antiga em texto puro como '123456')
                                    Console.WriteLine($"Erro ao verificar hash BCrypt: {exHash.Message}");
                                    senhaCorreta = false; // Garante que o login falhe se o hash for inválido
                                }

                                // 4. Se a senha estiver correta (hash bateu), cria o objeto Usuario.
                                if (senhaCorreta)
                                {
                                    // ---- FIM DA ALTERAÇÃO ----
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

                                    // ---- INÍCIO DA ALTERAÇÃO (BCrypt) ----
                                    // ADICIONADO: Fechamento do bloco 'if (senhaCorreta)'
                                }
                                // ADICIONADO: Se senhaCorreta for false, 'usuarioTecnico' continua 'null'.
                                // ---- FIM DA ALTERAÇÃO ----
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
