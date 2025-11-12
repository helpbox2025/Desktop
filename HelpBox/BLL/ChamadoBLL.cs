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
        public List<Chamado> ListarChamadosParaGrid()
        {
            try { return chamadoDAL.ListarChamadosParaGrid(); }
            catch (Exception) { throw; }
        }
        public Chamado GetChamadoPorId(int id)
        {
            if (id <= 0) { throw new Exception("ID do chamado é inválido."); }
            try { return chamadoDAL.GetChamadoPorId(id); }
            catch (Exception) { throw; }
        }
        public void SalvarSolucaoTecnico(int id, string solucao)
        {
            if (string.IsNullOrWhiteSpace(solucao)) { throw new Exception("A solução do técnico não pode estar vazia."); }
            try { chamadoDAL.SalvarSolucaoTecnico(id, solucao); }
            catch (Exception) { throw; }
        }
        public void FinalizarChamado(int id)
        {
            if (id <= 0) { throw new Exception("ID do chamado é inválido."); }
            try { chamadoDAL.FinalizarChamado(id); }
            catch (Exception ex) { throw ex; }
        }
        public bool AtribuirChamado(int idChamado, int idTecnico)
        {
            if (idTecnico <= 0)
            {
                throw new Exception("ID do técnico é inválido.");
            }

            try
            {
                // Chama o método corrigido da DAL
                return chamadoDAL.AtribuirChamado(idChamado, idTecnico);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}