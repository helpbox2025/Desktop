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

        private void ExecutarLogout()
        {
            string mensagem = "Deseja realmente deslogar?";
            string titulo = "Confirmação de Logout";

            // Define quais botões estarão disponíveis na caixa de mensagem. 
            MessageBoxButtons botoes = MessageBoxButtons.YesNo;

            // Define qual ícone será exibido na caixa de mensagem.
            MessageBoxIcon icone = MessageBoxIcon.Question;

            // Ele então RETORNA um valor que representa qual botão foi clicado (DialogResult.Yes ou DialogResult.No).
            // Esse valor retornado é armazenado na variável 'resultado'.
            DialogResult resultado = MessageBox.Show(mensagem, titulo, botoes, icone);

            // Verifica se o valor armazenado na variável 'resultado' é igual a DialogResult.Yes.
            if (resultado == DialogResult.Yes)
            {
                // Se o usuário clicou em "Sim", fecha p/ o login:
                this.Close();
            }
            // Se o usuário clicou em "Não" (ou fechou a caixa de mensagem pelo 'X'),

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // --- 1. LÓGICA PARA SALVAR A SOLUÇÃO ---
            // (Opcional, mas recomendado)
            // Antes de fechar, você provavelmente quer salvar
            // o que o técnico escreveu.

            // Exemplo (adapte para os nomes dos seus componentes):
            // string solucaoDoTecnico = txtSolucaoTecnico.Text;
            // MeuBancoDeDados.SalvarSolucao(idDoChamado, solucaoDoTecnico);

            // Mostra uma mensagem de sucesso
            MessageBox.Show("Solução salva com sucesso!");


            // --- 2. FECHAR A TELA ATUAL ---
            // Este comando fecha a janela/formulário atual
            // e automaticamente retorna o foco para a tela
            // que a abriu (sua tela principal).
            this.Close();
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

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

            // Mostra uma mensagem de sucesso
            MessageBox.Show("Chamado finalizado com sucesso!");
            //Fecha a tela atual
            this.Close();
        }

        private void stripLogoutDetalhes_Click(object sender, EventArgs e)
        {
            ExecutarLogout();
        }
    }
}
