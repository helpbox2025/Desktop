using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpBox.Model
{
    public class Chamado
    {
        // Usei os nomes da sua imagem do SQL
        public int id_Cham { get; set; }
        public string status_Cham { get; set; }
        public DateTime dataAbertura_Cham { get; set; }
        public DateTime? dataFechamento_Cham { get; set; } // Pode ser nulo
        public DateTime? dataProblema_Cham { get; set; }   // Pode ser nulo
        public string prioridade_Cham { get; set; }
        public string categoria_Cham { get; set; }
        public string descricao_Cham { get; set; }
        public string solucaoIA_Cham { get; set; }
        public string solucaoTec_Cham { get; set; }
        public string solucaoFinal_Cham { get; set; }
        public string tecResponsavel_Cham { get; set; }
        public string titulo_Cham { get; set; } // Este é o seu "Assunto"
        public string impacto_Cham { get; set; }
        public string usuarios_Cham { get; set; }
        public string frequencia_Cham { get; set; }
        public int clienteId_Cham { get; set; }
    }
}