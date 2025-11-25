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

        //Inicializa a tela e recebe o ID do chamado selecionado.
        public frmDetalhesChamado(int idChamado) 
        {
            InitializeComponent();
            _idDoChamadoAtual = idChamado;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        // Exibe mensagem de confirmação e fecha a tela se o usuário confirmar o logout.
        private void ExecutarLogout() 
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

        // Salva a solução técnica digitada no banco de dados.
        private void button1_Click_1(object sender, EventArgs e) 
        {
            try
            {
                string solucao = txtSolucaoTec.Text;
                chamadoBLL.SalvarSolucaoTecnico(_idDoChamadoAtual, solucao);
                MessageBox.Show("Solução salva com sucesso!", "Sucesso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        // Exibe informações sobre a HelpBox.
        private void stripSobreHDetalhes_Click(object sender, EventArgs e) 
        {
            string mensagem = "A HelpBox é uma empresa especializada " +
                "em softwares para solucionamento interno de chamados " +
                "relacionados à problemas com hardware e software. Caso queira " +
                "saber mais ou abrir um chamado, " +
                "acesse a versão Web!";
            string titulo = "Sobre a HelpBox";
            MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        // Finaliza o chamado no sistema após confirmação do usuário.
        private void btnFinalizar_Click(object sender, EventArgs e) 
        {
            DialogResult confirmacao = MessageBox.Show(
                "Você tem certeza que deseja finalizar este chamado?" +
                "\nEsta ação não pode ser desfeita.",
                "Finalizar Chamado",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacao == DialogResult.Yes)
            {
                try
                {

                    chamadoBLL.FinalizarChamado(_idDoChamadoAtual);

                    MessageBox.Show("Chamado finalizado com sucesso!", 
                        "Sucesso", MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao finalizar o chamado: " + ex.Message);
                }
            }
        }

        // Chama a função de logout através do menu.
        private void stripLogoutDetalhes_Click(object sender, EventArgs e) 
        {
            ExecutarLogout();
        }

        // Carrega os dados do chamado assim que a tela é aberta.
        private void frmDetalhesChamado_Load(object sender, EventArgs e) 
        {

            CarregarDadosDoChamado();

        }

        // Busca o chamado no banco, preenche os campos
        // e bloqueia edição se estiver fechado.
        private void CarregarDadosDoChamado()
        {
            try
            {
                // Busca no banco os dados completos do chamado pelo ID atual
                Chamado chamado = chamadoBLL.GetChamadoPorId(_idDoChamadoAtual);

                // Se o chamado não existir, mostra erro e fecha a tela
                if (chamado == null)
                {
                    MessageBox.Show("Erro: Chamado não encontrado.");
                    this.Close();
                    return;
                }

                // Preenche os campos da tela com os dados do chamado
                txtAssunto.Text = chamado.titulo_Cham;
                txtDescricao.Text = chamado.descricao_Cham;
                txtCategoria.Text = chamado.categoria_Cham;
                txtImpacto.Text = chamado.impacto_Cham;
                txtFrequencia.Text = chamado.frequencia_Cham;

                // Formata a data do problema ou mostra "N/A" se a data estiver null
                txtInicioProb.Text = chamado.dataProblema?
                                 .ToShortDateString() ?? "N/A";

                txtAbrangencia.Text = chamado.usuarios_Cham;
                txtSolucaoIA.Text = chamado.solucaoIA_Cham;
                txtSolucaoTec.Text = chamado.solucaoTec_Cham;

                // Se o chamado estiver fechado, bloqueia edição e ações
                if (chamado.status_Cham.Equals("Fechado", StringComparison
                                                          .OrdinalIgnoreCase))
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
                // Caso ocorra algum erro inesperado, exibe a mensagem e fecha a tela
                MessageBox.Show("Erro ao carregar dados do chamado: " + ex.Message);
                this.Close();
            }
        }

        private void txtSolucaoTec_TextChanged(object sender, EventArgs e) 
        {

        }

        // Abre a janela do Manual do Sistema.
        private void stripMSistemaDetalhes_Click(object sender, EventArgs e) 
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
