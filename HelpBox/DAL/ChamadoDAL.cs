using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using HelpBox.Model; // Para usar a classe Chamado

namespace HelpBox.DAL
{
    public class ChamadoDAL
    {
        // Sua string de conexão (idealmente, viria do App.config ou de uma classe de Conexão)
        private string connectionString = "Server=localhost;Database=Helpbox;Integrated Security=True;TrustServerCertificate=True;";

        // Método para listar os chamados para a tela principal
        public List<Chamado> ListarChamadosParaGrid()
        {
            List<Chamado> listaDeChamados = new List<Chamado>();

            // Pegando os dados da sua tabela [Chamado] e colunas da imagem
            // Vamos pegar apenas o que o seu grid precisa
            string query = @"SELECT 
                                [id_Cham], 
                                [categoria_Cham], 
                                [titulo_Cham], 
                                [prioridade_Cham], 
                                [dataAbertura_Cham], 
                                [status_Cham] 
                             FROM [Chamado]";

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
                                chamado.titulo_Cham = reader["titulo_Cham"].ToString(); // "Assunto"
                                chamado.prioridade_Cham = reader["prioridade_Cham"].ToString();
                                chamado.dataAbertura_Cham = Convert.ToDateTime(reader["dataAbertura_Cham"]);
                                chamado.status_Cham = reader["status_Cham"].ToString();

                                listaDeChamados.Add(chamado);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Aqui você pode logar o erro
                throw new Exception("Erro na DAL ao listar chamados: " + ex.Message);
            }

            return listaDeChamados;
        }
        public Chamado GetChamadoPorId(int id)
        {
            Chamado chamado = null; // Começa como nulo

            // Pega TUDO da tabela Chamado onde o ID for o que passamos
            string query = "SELECT * FROM [Chamado] WHERE [id_Cham] = @Id";

            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    using (SqlCommand comando = new SqlCommand(query, conexao))
                    {
                        // Adiciona o parâmetro de ID
                        comando.Parameters.AddWithValue("@Id", id);

                        conexao.Open();
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            // Se encontrou uma linha...
                            if (reader.Read())
                            {
                                // Preenche o objeto Chamado com TODOS os dados
                                chamado = new Chamado();
                                chamado.id_Cham = Convert.ToInt32(reader["id_Cham"]);
                                chamado.status_Cham = reader["status_Cham"].ToString();
                                chamado.dataAbertura_Cham = Convert.ToDateTime(reader["dataAbertura_Cham"]);

                                // Tratamento para campos que podem ser nulos (DBNull)
                                chamado.dataFechamento_Cham = reader["dataFechamento_Cham"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["dataFechamento_Cham"]);
                                //chamado.dataProblema_Cham = reader["dataProblema_Cham"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(reader["dataProblema_Cham"]);

                                chamado.prioridade_Cham = reader["prioridade_Cham"].ToString();
                                chamado.categoria_Cham = reader["categoria_Cham"].ToString();
                                chamado.descricao_Cham = reader["descricao_Cham"].ToString();
                                chamado.solucaoIA_Cham = reader["solucaoIA_Cham"].ToString();
                                chamado.solucaoTec_Cham = reader["solucaoTec_Cham"].ToString();
                                chamado.solucaoFinal_Cham = reader["solucaoFinal_Cham"].ToString();
                                chamado.tecResponsavel_Cham = reader["tecResponsavel_Cham"].ToString();
                                chamado.titulo_Cham = reader["titulo_Cham"].ToString(); // Assunto
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

            return chamado; // Retorna o chamado preenchido (ou nulo se não achou)
        }

        // MÉTODO NOVO para salvar a solução do técnico
        public void SalvarSolucaoTecnico(int id, string solucao)
        {
            string query = "UPDATE [Chamado] SET [solucaoTec_Cham] = @Solucao WHERE [id_Cham] = @Id";

            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    using (SqlCommand comando = new SqlCommand(query, conexao))
                    {
                        // Adiciona os parâmetros
                        comando.Parameters.AddWithValue("@Solucao", solucao);
                        comando.Parameters.AddWithValue("@Id", id);

                        conexao.Open();
                        comando.ExecuteNonQuery(); // Apenas executa a atualização, não retorna nada
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro na DAL ao salvar solução: " + ex.Message);
            }
        }
    }
}
