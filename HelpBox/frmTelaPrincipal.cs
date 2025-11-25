using HelpBox.BLL;
using HelpBox.DAL;
using HelpBox.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HelpBox
{
    public partial class frmTelaPrincipal : Form
    {
        private ChamadoBLL chamadoBLL = new ChamadoBLL();
        private int larguraMenuAberto = 280;
        private int larguraMenuFechado = 0;
        private int passoAnimacao = 30;
        private bool menuAberto = false;

        private List<Chamado> _listaDeChamadosAtual;
        private Usuario usuarioLogado;
        public frmTelaPrincipal(Usuario usuario) // Inicializa a tela e recebe o objeto do usuário logado.
        {
            InitializeComponent();
            this.usuarioLogado = usuario;
        }

        private void frmTelaPrincipal_Load(object sender, EventArgs e) // Configura o layout inicial, exibe mensagem de boas-vindas e carrega a lista de chamados.
        {
            this.splicontPrincipal.Panel1Collapsed = false;
            this.splicontPrincipal.SplitterDistance = this.larguraMenuAberto;
            this.menuAberto = true;
            tsmMenuLateral.BackColor = Color.DarkSlateGray;

            if (this.usuarioLogado != null)
            {
                lblBoasVindas.Text = $"Olá, {this.usuarioLogado.nome_User}!";
                lblEmail.Text = this.usuarioLogado.email_User;
            }
            else
            {
                lblBoasVindas.Text = "Olá, Técnico!";
                lblEmail.Text = "email@exemplo.com";
            }

            CarregarChamados();

            if (this.usuarioLogado != null)
            {
                lblBoasVindas.Text = $"Olá, {this.usuarioLogado.nome_User}!";
                lblEmail.Text = this.usuarioLogado.email_User;
            }
            else
            {
                lblBoasVindas.Text = "Olá, Técnico!";
                lblEmail.Text = "email@exemplo.com";
            }
        }
        private void CarregarChamados() // Busca os chamados no banco, preenche a tabela e define as cores dos botões de ação.
        {
            dgvChamados.Rows.Clear();
            try
            {
                int meuID = this.usuarioLogado.id_User;
                _listaDeChamadosAtual = chamadoBLL.ListarChamadosParaGrid(meuID);


                foreach (var chamado in _listaDeChamadosAtual)
                {
                    int rowIndex = dgvChamados.Rows.Add(
                        chamado.id_Cham,
                        chamado.categoria_Cham,
                        chamado.titulo_Cham,
                        chamado.prioridade_Cham,
                        chamado.dataAbertura_Cham.ToShortDateString(),
                        chamado.status_Cham,
                        chamado.TecResponsavelNomeCompleto
                    );
                    if (chamado.tecResponsavel_Cham != null)
                    {
                        DataGridViewButtonCell cell = (DataGridViewButtonCell)dgvChamados.Rows[rowIndex].Cells["ColunaSolucionar"];
                        cell.Value = "Em Atendimento";

                        if (chamado.tecResponsavel_Cham == meuID)
                        {
                            cell.Style.BackColor = Color.CornflowerBlue;
                        }
                        else
                        {
                            cell.Style.BackColor = Color.Gray;
                        }
                        cell.Style.ForeColor = Color.White;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar chamados: " + ex.Message);
            }
        }
        private void dgvChamados_CellContentClick(object sender, DataGridViewCellEventArgs e) // Gerencia os cliques nos botões da tabela (Solucionar/Detalhes) e valida se o técnico pode acessar o chamado.
        {
            if (e.RowIndex < 0) return;

            int idDoChamado = Convert.ToInt32(dgvChamados.Rows[e.RowIndex].Cells["ColunaIdCham"].Value);
            string nomeColuna = dgvChamados.Columns[e.ColumnIndex].Name;

            Chamado chamadoClicado = _listaDeChamadosAtual.FirstOrDefault(c => c.id_Cham == idDoChamado);
            if (chamadoClicado == null) return;
            int meuID = this.usuarioLogado.id_User; 
            int? tecnicoID = chamadoClicado.tecResponsavel_Cham;
            string tecnicoNome = chamadoClicado.TecResponsavelNomeCompleto;

            if (nomeColuna == "ColunaSolucionar")
            {
                if (!tecnicoID.HasValue)
                {
                    DialogResult confirmacao = MessageBox.Show(
                        "Deseja atribuir este chamado a você e iniciar a solução?",
                        "Confirmar Ação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmacao == DialogResult.Yes)
                    {
                        bool sucesso = chamadoBLL.AtribuirChamado(idDoChamado, meuID);

                        if (sucesso)
                        {
                            AbrirDetalhes(idDoChamado);
                        }
                        else
                        {
                            MessageBox.Show("Este chamado acabou de ser pego por outro técnico. A lista será atualizada.", "Conflito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        CarregarChamados();
                    }
                }
                else if (tecnicoID.Value == meuID)
                {
                    AbrirDetalhes(idDoChamado);
                }
                else
                {
                    MessageBox.Show("Este chamado já está sendo solucionado por: " + tecnicoNome, "Chamado Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (nomeColuna == "ColunaDetalhes")
            {
                if (tecnicoID.HasValue && tecnicoID.Value == meuID)
                {
                    AbrirDetalhes(idDoChamado);
                }
                else if (!tecnicoID.HasValue)
                {
                    MessageBox.Show("Você deve primeiro clicar em 'Solucionar' para atribuir este chamado a você.", "Ação Necessária", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Este chamado está sendo solucionado por: " + tecnicoNome + ". Você não pode ver os detalhes.", "Chamado Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void AbrirDetalhes(int idDoChamado) // Abre a janela de detalhes do chamado e atualiza a lista ao retornar.
        {
            using (frmDetalhesChamado telaDeDetalhes = new frmDetalhesChamado(idDoChamado))
            {
                telaDeDetalhes.ShowDialog();
            }
            CarregarChamados();
        }
        private void ExecutarLogout() // Fecha a tela atual para realizar o logout.
        {
            this.Close();
        }
        private void btnLogOut_Click(object sender, EventArgs e) // Chama a função de logout ao clicar no botão.
        {
            ExecutarLogout();
        }
        private void stripLogoutPrincipal_Click(object sender, EventArgs e) // Chama a função de logout através do menu superior.
        {
            ExecutarLogout();
        }
        private void frmTelaPrincipal_FormClosing(object sender, FormClosingEventArgs e) // Exibe confirmação ao tentar fechar a janela e cancela se o usuário negar.
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult resultado = MessageBox.Show("Deseja realmente deslogar?", "Confirmação de Saída", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e) // Alterna o estado do menu lateral (abrir/fechar) e inicia a animação.
        {
            if (timerMenu.Enabled) return;
            menuAberto = !menuAberto;
            if (menuAberto)
            {
                splicontPrincipal.Panel1Collapsed = false;
            }
            timerMenu.Start();
        }
        private void timerMenu_Tick(object sender, EventArgs e) // Controla a animação de deslize do menu lateral a cada "tick" do temporizador.
        {
            if (menuAberto)
            {
                if (splicontPrincipal.SplitterDistance < larguraMenuAberto) { splicontPrincipal.SplitterDistance += passoAnimacao; }
                else
                {
                    splicontPrincipal.SplitterDistance = larguraMenuAberto;
                    timerMenu.Stop();
                    tsmMenuLateral.BackColor = Color.DarkSlateGray;
                }
            }
            else
            {
                if ((splicontPrincipal.SplitterDistance - passoAnimacao) > larguraMenuFechado) { splicontPrincipal.SplitterDistance -= passoAnimacao; }
                else
                {
                    splicontPrincipal.SplitterDistance = larguraMenuFechado;
                    timerMenu.Stop();
                    splicontPrincipal.Panel1Collapsed = true;
                    tsmMenuLateral.BackColor = Color.Transparent;
                }
            }
        }
        private void stripSobreHPrincipal_Click(object sender, EventArgs e) // Exibe informações sobre a empresa HelpBox.
        {
            string mensagem = "A HelpBox é uma empresa especializada em softwares para solucionamento interno de chamados relacionados à problemas com hardware e software. Caso queira saber mais ou abrir um chamado, " +
                "acesse a versão Web!";
            string titulo = "Sobre a HelpBox";
            MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void panelLogo_Paint(object sender, PaintEventArgs e) 
        {

        }
        private void btnManual_Click(object sender, EventArgs e) // Abre a janela do Manual do Sistema pelo botão lateral.
        {
            frmManual tela = new frmManual();
            tela.ShowDialog(); 
        }
        private void stripManualPrincipal_Click(object sender, EventArgs e)
        {

        }
        private void stripMSistemaPrincipal_Click(object sender, EventArgs e) // Abre a janela do Manual do Sistema pelo menu superior.
        {
            frmManual tela = new frmManual();
            tela.ShowDialog();
        }
        private void lblEmail_Click(object sender, EventArgs e)
        {

        }
        private void lblBoasVindas_Click(object sender, EventArgs e)
        {

        }
    }
}