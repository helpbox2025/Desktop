using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using HelpBox.Model;

namespace HelpBox.DAL
{
    public class ChamadoDAL
    {
        private string connectionString = "Server=localhost;Database=Helpbox;Integrated Security=True;TrustServerCertificate=True;";

        // --- !! MÉTODO CORRIGIDO COM LEFT JOIN !! ---
        public List<Chamado> ListarChamadosParaGrid()
        {
            List<Chamado> listaDeChamados = new List<Chamado>();

            string query = @"SELECT 
                                 c.[id_Cham], 
                                 c.[categoria_Cham], 
                                 c.[titulo_Cham], 
                                 c.[prioridade_Cham], 
                                 c.[dataAbertura_Cham], 
                                 c.[status_Cham],
                                 c.[tecResponsavel_Cham],
                                 -- Concatena nome e sobrenome da tabela Usuario
                                 ISNULL(u.[nome_User] + ' ' + u.[sobrenome_User], '') as TecResponsavelNomeCompleto
                             FROM 
                                 [Chamado] c
                             LEFT JOIN 
                                 [Usuario] u ON c.[tecResponsavel_Cham] = u.[id_User]"; // Faz a "ponte"

            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    using (SqlCommand comando = new SqlCommand(query, conexao))
                    {
                        conexao.Open();
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Chamado chamado = new Chamado();
                                chamado.id_Cham = Convert.ToInt32(reader["id_Cham"]);
                                chamado.categoria_Cham = reader["categoria_Cham"].ToString();
                                chamado.titulo_Cham = reader["titulo_Cham"].ToString();
                                chamado.prioridade_Cham = reader["prioridade_Cham"].ToString();
                                chamado.dataAbertura_Cham = Convert.ToDateTime(reader["dataAbertura_Cham"]);
                                chamado.status_Cham = reader["status_Cham"].ToString();
                                chamado.tecResponsavel_Cham = reader["tecResponsavel_Cham"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["tecResponsavel_Cham"]);
                                chamado.TecResponsavelNomeCompleto = reader["TecResponsavelNomeCompleto"].ToString();

                                listaDeChamados.Add(chamado);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na DAL ao listar chamados: " + ex.Message);
            }
            return listaDeChamados;
        }

        // --- !! MÉTODO CORRIGIDO PARA LER O ID !! ---
        public Chamado GetChamadoPorId(int id)
        {
            Chamado chamado = null;
            string query = "SELECT * FROM [Chamado] WHERE [id_Cham] = @Id"; // (Idealmente, este também teria o JOIN)

            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    using (SqlCommand comando = new SqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@Id", id);
                        conexao.Open();
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                chamado = new Chamado();
                                // ... (id_Cham, status_Cham, etc...)
                                chamado.id_Cham = Convert.ToInt32(reader["id_Cham"]);
                                chamado.status_Cham = reader["status_Cham"].ToString();
                                chamado.dataAbertura_Cham = Convert.ToDateTime(reader["dataAbertura_Cham"]);
                                chamado.dataFechamento_Cham = reader["dataFechamento_Cham"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["dataFechamento_Cham"]);

                                //chamado.dataProblema_Cham = reader["dataProblema_Cham"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["dataProblema_Cham"]);

                                chamado.prioridade_Cham = reader["prioridade_Cham"].ToString();
                                chamado.categoria_Cham = reader["categoria_Cham"].ToString();
                                chamado.descricao_Cham = reader["descricao_Cham"].ToString();
                                chamado.solucaoIA_Cham = reader["solucaoIA_Cham"].ToString();
                                chamado.solucaoTec_Cham = reader["solucaoTec_Cham"].ToString();
                                chamado.solucaoFinal_Cham = reader["solucaoFinal_Cham"].ToString();

                                // !! CORREÇÃO !!: Lê o ID (int?)
                                chamado.tecResponsavel_Cham = reader["tecResponsavel_Cham"] == DBNull.Value ? (int?)null : Convert.ToInt32(reader["tecResponsavel_Cham"]);

                                chamado.titulo_Cham = reader["titulo_Cham"].ToString();
                                chamado.impacto_Cham = reader["impacto_Cham"].ToString();
                                chamado.usuarios_Cham = reader["usuarios_Cham"].ToString();
                                chamado.frequencia_Cham = reader["frequencia_Cham"].ToString();
                                chamado.clienteId_Cham = Convert.ToInt32(reader["clienteId_Cham"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na DAL ao buscar chamado por ID: " + ex.Message);
            }
            return chamado;
        }

        public void SalvarSolucaoTecnico(int id, string solucao)
        {
            // Este método está correto, não mexe com o responsável
            string query = "UPDATE [Chamado] SET [solucaoTec_Cham] = @Solucao WHERE [id_Cham] = @Id";
            // ... (O resto do seu código deste método está correto) ...
            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                using (SqlCommand comando = new SqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@Solucao", solucao);
                    comando.Parameters.AddWithValue("@Id", id);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na DAL ao salvar solução: " + ex.Message);
            }
        }

        public void FinalizarChamado(int id)
        {
            // Este método está correto
            string query = "UPDATE [Chamado] SET [status_Cham] = 'Fechado', [dataFechamento_Cham] = GETDATE() WHERE [id_Cham] = @Id";
            // ... (O resto do seu código deste método está correto) ...
            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                using (SqlCommand comando = new SqlCommand(query, conexao))
                {
                    comando.Parameters.AddWithValue("@Id", id);
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na DAL ao finalizar chamado: " + ex.Message);
            }
        }

        public bool AtribuirChamado(int idChamado, int idTecnico)
        {
            // Atualiza o ID do responsável E o status
            string query = @"UPDATE [Chamado] 
                             SET [tecResponsavel_Cham] = @IdTecnico, [status_Cham] = 'Em Andamento' 
                             WHERE [id_Cham] = @IdChamado 
                             AND [tecResponsavel_Cham] IS NULL"; // SÓ ATUALIZA SE ESTIVER LIVRE

            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                using (SqlCommand comando = new SqlCommand(query, conexao))
                {
                    // !! CORREÇÃO !!
                    comando.Parameters.AddWithValue("@IdTecnico", idTecnico);
                    comando.Parameters.AddWithValue("@IdChamado", idChamado);

                    conexao.Open();
                    int rowsAffected = comando.ExecuteNonQuery();
                    return rowsAffected > 0; // Retorna true se conseguiu atualizar
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na DAL ao atribuir chamado: " + ex.Message);
            }
        }
    }
}