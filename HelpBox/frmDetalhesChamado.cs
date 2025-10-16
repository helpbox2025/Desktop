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
    public partial class frmDetalhesChamado : Form
    {
        public frmDetalhesChamado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void stripSobreHDetalhes_Click(object sender, EventArgs e)
        {
            // Define o texto que será exibido na mensagem
            string mensagem = "A HelpBox é uma empresa especializada em softwares para solucionamento interno de chamados relacionados à problemas com hardware e software. Caso queira saber mais ou abrir um chamado, acesse: ";

            // Define o título da janela da mensagem
            string titulo = "Sobre a HelpBox";

            // Mostra a caixa de mensagem com o botão OK e o ícone de Informação
            MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
