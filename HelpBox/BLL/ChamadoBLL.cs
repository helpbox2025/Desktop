using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelpBox.DAL;
using HelpBox.Model;

namespace HelpBox.BLL
{
    public class ChamadoBLL
    {
        private ChamadoDAL chamadoDAL = new ChamadoDAL();
       
        public List<Chamado> ListarChamadosParaGrid(int idTecnicoLogado) // Busca a lista de chamados disponíveis e associados ao técnico para exibir na grid.
        {
            try { return chamadoDAL.ListarChamadosParaGrid(idTecnicoLogado); }
            catch (Exception) { throw; }
        }
        public Chamado GetChamadoPorId(int id) // Valida o ID e busca os detalhes completos de um chamado específico.
        {
            if (id <= 0) { throw new Exception("ID do chamado é inválido."); }
            try { return chamadoDAL.GetChamadoPorId(id); }
            catch (Exception) { throw; }
        }
        public void SalvarSolucaoTecnico(int id, string solucao) // Verifica se a solução não está vazia e salva a resposta técnica no banco.
        {
            if (string.IsNullOrWhiteSpace(solucao)) { throw new Exception("A solução do técnico não pode estar vazia."); }
            try { chamadoDAL.SalvarSolucaoTecnico(id, solucao); }
            catch (Exception) { throw; }
        }
        public void FinalizarChamado(int id) // Valida o ID e executa a finalização do chamado.
        {
            if (id <= 0) { throw new Exception("ID do chamado é inválido."); }
            try { chamadoDAL.FinalizarChamado(id); }
            catch (Exception ex) { throw ex; }
        }
        public bool AtribuirChamado(int idChamado, int idTecnico) // Tenta atribuir um chamado ao técnico, retornando verdadeiro ou falso (para controle de concorrência).
        {
            if (idTecnico <= 0)
            {
                throw new Exception("ID do técnico é inválido.");
            }

            try // Chama o método corrigido da DAL
            {
                
                return chamadoDAL.AtribuirChamado(idChamado, idTecnico);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}