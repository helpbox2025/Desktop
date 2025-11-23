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
        public frmManual()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmManual_Load(object sender, EventArgs e)
        {
            try
            {
                // Procura o arquivo na mesma pasta onde o programa (.exe) está rodando
                string caminhoArquivo = System.IO.Path.Combine(Application.StartupPath, "Manual.rtf");

                // Carrega o arquivo dentro da caixa de texto
                richTextBox1.LoadFile(caminhoArquivo);
            }
            catch (Exception)
            {
                richTextBox1.Text = "Manual não encontrado. Verifique se o arquivo 'Manual.rtf' está na pasta.";
            }
        }
    }
}
