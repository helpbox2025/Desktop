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
    public partial class frmTelaInicial : Form
    {
        public frmTelaInicial()
        {
            InitializeComponent();
        }

        private void BtnAbrirCham_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para abrir um chamado, acesse a versão Web!",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }
    }
}
