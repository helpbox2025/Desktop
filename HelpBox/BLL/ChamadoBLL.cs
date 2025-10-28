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
            // Aqui você pode adicionar regras de negócio (ex: se o usuário pode ver todos)
            // Por enquanto, vamos apenas chamar a DAL
            try
            {
                return chamadoDAL.ListarChamadosParaGrid();
            }
            catch (Exception )
            {
                // Tratar ou relançar o erro
                throw;
            }
        }
        public Chamado GetChamadoPorId(int id)
        {
            if (id <= 0)
            {
                throw new Exception("ID do chamado é inválido.");
            }

            try
            {
                return chamadoDAL.GetChamadoPorId(id);
            }
            catch (Exception )
            {
                throw;
            }
        }
        public void SalvarSolucaoTecnico(int id, string solucao)
        {
            if (string.IsNullOrWhiteSpace(solucao))
            {
                throw new Exception("A solução do técnico não pode estar vazia.");
            }

            try
            {
                chamadoDAL.SalvarSolucaoTecnico(id, solucao);
            }
            catch (Exception )
            {
                throw;
            }
        }
    }
}
