using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpBox
{
    public partial class frmTelaPrincipal : Form
    {

        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void frmTelaPrincipal_Load(object sender, EventArgs e)
        {
            // Chama o nosso método para preencher a grade assim que a tela carregar
            CarregarDadosFicticios();
        }

        private void CarregarDadosFicticios()
        {
            // Limpa apenas as LINHAS existentes para não acumular dados a cada teste
            dgvChamados.Rows.Clear();

            // DADOS FICTÍCIOS
            // A ordem dos dados que adicionamos abaixo deve ser a mesma das suas colunas de texto:
            // ID Chamado, Categoria, Assunto, Prioridade, Data de Abertura, Status

            // Linha 1
            dgvChamados.Rows.Add("020310", "Software", "Erro ao emitir nota fiscal", "Média", "06/10/2025", "Aberto");

            // Linha 2
            dgvChamados.Rows.Add("232665", "Software", "Sistema lento após atualização", "Alta", "08/10/2025", "Andamento");

            // Linha 3
            dgvChamados.Rows.Add("023694", "Hardware", "Impressora da recepção não funciona", "Baixa", "07/10/2025", "Aberto");

            // Linha 4
            dgvChamados.Rows.Add("558963", "Hardware", "Monitor do estoque está piscando", "Média", "07/10/2025", "Aberto");

            // Linha 5
            dgvChamados.Rows.Add("785321", "Software", "Login de novo funcionário não funciona", "Alta", "08/10/2025", "Aberto");
        }
    }
}
