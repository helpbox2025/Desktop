using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpBox.Model
{
    // Classe modelo que representa a estrutura de
    // dados de um Chamado (Ticket) no sistema.
    public class Chamado 
    {
        // Propriedades que mapeiam as colunas da
        // tabela de chamados no banco de dados.
        public int id_Cham { get; set; }
        public string status_Cham { get; set; }
        public DateTime dataAbertura_Cham { get; set; }
        public DateTime? dataFechamento_Cham { get; set; }
        public DateTime? dataProblema { get; set; }
        public string prioridade_Cham { get; set; }
        public string categoria_Cham { get; set; }
        public string descricao_Cham { get; set; }
        public string solucaoIA_Cham { get; set; }
        public string solucaoTec_Cham { get; set; }
        public string solucaoFinal_Cham { get; set; }
        public int? tecResponsavel_Cham { get; set; }
        public string titulo_Cham { get; set; }
        public string impacto_Cham { get; set; }
        public string usuarios_Cham { get; set; }
        public string frequencia_Cham { get; set; }
        public int clienteId_Cham { get; set; }

        // Propriedade auxiliar para exibir o nome do técnico
        // na interface (não é gravada na tabela Chamado).
        public string TecResponsavelNomeCompleto { get; set; } 
    }
}