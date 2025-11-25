using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HelpBox.BLL;
using HelpBox.Model;
namespace HelpBox
{
    public partial class frmDetalhesChamado : Form
    {
        private int _idDoChamadoAtual;
        private ChamadoBLL chamadoBLL = new ChamadoBLL();

        public frmDetalhesChamado(int idChamado) //Inicializa a tela e recebe o ID do chamado selecionado.
        {
            InitializeComponent();
            _idDoChamadoAtual = idChamado;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ExecutarLogout() // Exibe mensagem de confirmação e fecha a tela se o usuário confirmar o logout.
        {
            string mensagem = "Deseja realmente deslogar?";
            string titulo = "Confirmação de Logout"; 
            MessageBoxButtons botoes = MessageBoxButtons.YesNo;
            MessageBoxIcon icone = MessageBoxIcon.Question;
            DialogResult resultado = MessageBox.Show(mensagem, titulo, botoes, icone);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e) // Salva a solução técnica digitada no banco de dados.
        {
            try
            {
                string solucao = txtSolucaoTec.Text;
                chamadoBLL.SalvarSolucaoTecnico(_idDoChamadoAtual, solucao);
                MessageBox.Show("Solução salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar solução: " + ex.Message);
            }
        }

        private void textDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void stripSobreHDetalhes_Click(object sender, EventArgs e) // Exibe informações sobre a HelpBox.
        {
            string mensagem = "A HelpBox é uma empresa especializada em softwares para solucionamento interno de chamados relacionados à problemas com hardware e software. Caso queira saber mais ou abrir um chamado, " +
                "acesse a versão Web!";
            string titulo = "Sobre a HelpBox";
            MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFinalizar_Click(object sender, EventArgs e) // Finaliza o chamado no sistema após confirmação do usuário.
        {
            DialogResult confirmacao = MessageBox.Show(
                "Você tem certeza que deseja finalizar este chamado?\nEsta ação não pode ser desfeita.",
                "Finalizar Chamado",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacao == DialogResult.Yes)
            {
                try
                {

                    chamadoBLL.FinalizarChamado(_idDoChamadoAtual);

                    MessageBox.Show("Chamado finalizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao finalizar o chamado: " + ex.Message);
                }
            }
        }

        private void stripLogoutDetalhes_Click(object sender, EventArgs e) // Chama a função de logout através do menu.
        {
            ExecutarLogout();
        }
        private void frmDetalhesChamado_Load(object sender, EventArgs e) // Carrega os dados do chamado assim que a tela é aberta.
        {

            CarregarDadosDoChamado();

        }
        private void CarregarDadosDoChamado() // Busca o chamado no banco, preenche os campos e bloqueia edição se estiver fechado.
        {
            try
            {
                Chamado chamado = chamadoBLL.GetChamadoPorId(_idDoChamadoAtual);

                if (chamado == null)
                {
                    MessageBox.Show("Erro: Chamado não encontrado.");
                    this.Close();
                    return;
                }

                txtAssunto.Text = chamado.titulo_Cham;
                txtDescricao.Text = chamado.descricao_Cham;
                txtCategoria.Text = chamado.categoria_Cham;
                txtImpacto.Text = chamado.impacto_Cham;
                txtFrequencia.Text = chamado.frequencia_Cham;
                txtInicioProb.Text = chamado.dataProblema_Cham?.ToShortDateString() ?? "N/A";
                txtAbrangencia.Text = chamado.usuarios_Cham;
                txtSolucaoIA.Text = chamado.solucaoIA_Cham;
                txtSolucaoTec.Text = chamado.solucaoTec_Cham;

                if (chamado.status_Cham.Equals("Fechado", StringComparison.OrdinalIgnoreCase))
                {
                    txtSolucaoTec.ReadOnly = true;
                    btnSalvar.Enabled = false;
                    btnFinalizar.Enabled = false;
                    btnFinalizar.Text = "Chamado Fechado";
                    btnSalvar.Text = "Bloqueado";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados do chamado: " + ex.Message);
                this.Close();
            }
        }
        private void txtSolucaoTec_TextChanged(object sender, EventArgs e) 
        {

        }

        private void stripMSistemaDetalhes_Click(object sender, EventArgs e) // Abre a janela do Manual do Sistema.
        {
            frmManual tela = new frmManual();
            tela.ShowDialog();
        }

        private void stripSobreDetalhes_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxDetalhes_Enter(object sender, EventArgs e)
        {

        }
    }
}
