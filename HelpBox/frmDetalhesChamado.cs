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
        // Variável para guardar o ID do chamado que está aberto
        private int _idDoChamadoAtual;

        // Instância da BLL
        private ChamadoBLL chamadoBLL = new ChamadoBLL();
        public frmDetalhesChamado(int idChamado)
        {
            InitializeComponent();

            // Guarda o ID
            _idDoChamadoAtual = idChamado;
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
            try
            {
                // Pega a solução do TextBox
                // (!! ADAPTE o nome 'txtSolucaoTecnico' !!)
                string solucao = txtSolucaoTec.Text;

                // Chama a BLL para salvar
                chamadoBLL.SalvarSolucaoTecnico(_idDoChamadoAtual, solucao);

                MessageBox.Show("Solução salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Fecha a tela (e volta para a tela principal)
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
            // 1. Mostra uma confirmação (é uma ação permanente)
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

        private void stripLogoutDetalhes_Click(object sender, EventArgs e)
        {
            ExecutarLogout();
        }
        private void frmDetalhesChamado_Load(object sender, EventArgs e)
        {

            CarregarDadosDoChamado();

        }
        private void CarregarDadosDoChamado()
        {
            try
            {
                // Busca o chamado completo usando a BLL
                Chamado chamado = chamadoBLL.GetChamadoPorId(_idDoChamadoAtual);

                if (chamado == null)
                {
                    MessageBox.Show("Erro: Chamado não encontrado.");
                    this.Close();
                    return;
                }

                // !!! ADAPTE OS NOMES DOS SEUS TEXTBOX AQUI !!!
                // (Estou usando nomes baseados na sua primeira imagem)

                txtAssunto.Text = chamado.titulo_Cham;
                txtDescricao.Text = chamado.descricao_Cham;
                txtCategoria.Text = chamado.categoria_Cham;
                txtImpacto.Text = chamado.impacto_Cham;
                txtFrequencia.Text = chamado.frequencia_Cham;
                txtInicioProb.Text = chamado.dataProblema_Cham?.ToShortDateString() ?? "N/A";
                txtAbrangencia.Text = chamado.usuarios_Cham; // (Exemplo, mude se for outra coluna)
                txtSolucaoIA.Text = chamado.solucaoIA_Cham;
                txtSolucaoTec.Text = chamado.solucaoTec_Cham;

                if (chamado.status_Cham.Equals("Fechado", StringComparison.OrdinalIgnoreCase))
                {
                    // (!! ADAPTE OS NOMES DOS SEUS CONTROLES !!)

                    // 1. Torna a caixa de solução do técnico "somente leitura"
                    txtSolucaoTec.ReadOnly = true;

                    // 2. Desabilita os botões
                    btnSalvar.Enabled = false;
                    btnFinalizar.Enabled = false;

                    // 3. (Opcional) Muda o texto para dar feedback
                    btnFinalizar.Text = "Chamado Fechado";
                    btnSalvar.Text = "Bloqueado";
                }
                // (Preencha os outros campos que você precisar)
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

        private void stripMSistemaDetalhes_Click(object sender, EventArgs e)
        {
            frmManual tela = new frmManual();
            tela.ShowDialog();
        }
    }
}
