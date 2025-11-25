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

        // Busca a lista de chamados disponíveis e associados ao técnico para exibir na grid.
        public List<Chamado> ListarChamadosParaGrid(int idTecnicoLogado) 
        {
            try { return chamadoDAL.ListarChamadosParaGrid(idTecnicoLogado); }
            catch (Exception) { throw; }
        }

        // Valida o ID e busca os detalhes completos de um chamado específico.
        public Chamado GetChamadoPorId(int id) 
        {
            if (id <= 0) { throw new Exception("ID do chamado é inválido."); }
            try { return chamadoDAL.GetChamadoPorId(id); }
            catch (Exception) { throw; }
        }

        // Verifica se a solução não está vazia e salva a resposta técnica no banco.
        public void SalvarSolucaoTecnico(int id, string solucao) 
        {
            if (string.IsNullOrWhiteSpace(solucao)) { throw new Exception("A solução do técnico não pode estar vazia."); }
            try { chamadoDAL.SalvarSolucaoTecnico(id, solucao); }
            catch (Exception) { throw; }
        }

        // Valida o ID e executa a finalização do chamado.
        public void FinalizarChamado(int id) 
        {
            if (id <= 0) { throw new Exception("ID do chamado é inválido."); }
            try { chamadoDAL.FinalizarChamado(id); }
            catch (Exception ex) { throw ex; }
        }

        // Tenta atribuir um chamado ao técnico,
        // retornando verdadeiro ou falso (para controle de concorrência).
        public bool AtribuirChamado(int idChamado, int idTecnico) 
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