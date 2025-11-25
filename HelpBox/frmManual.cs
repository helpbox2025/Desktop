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
    public partial class frmManual : Form
    {
        public frmManual()//Inicializa os componentes visuais da tela de manual.
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmManual_Load(object sender, EventArgs e) // Tenta carregar o arquivo 'Manual.rtf' na caixa de texto ao abrir a janela.
        {
            try
            {
                string caminhoArquivo = System.IO.Path.Combine(Application.StartupPath, "Manual.rtf");
                richTextBox1.LoadFile(caminhoArquivo);
            }
            catch (Exception)
            {
                richTextBox1.Text = "Manual não encontrado. Verifique se o arquivo 'Manual.rtf' está na pasta.";
            }
        }
    }
}
