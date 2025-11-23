using HelpBox.BLL;
using HelpBox.DAL;
using HelpBox.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq; // Necessário para .FirstOrDefault()
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HelpBox
{
    public partial class frmTelaPrincipal : Form
    {
        private ChamadoBLL chamadoBLL = new ChamadoBLL();

        // --- Variáveis de Classe ---
        private int larguraMenuAberto = 280;
        private int larguraMenuFechado = 0;
        private int passoAnimacao = 30;
        private bool menuAberto = false;

        private List<Chamado> _listaDeChamadosAtual;
        private Usuario usuarioLogado; // Seu código usa 'usuarioLogado' (minúsculo)

        // --- Construtor ---
        public frmTelaPrincipal(Usuario usuario)
        {
            InitializeComponent();
            this.usuarioLogado = usuario;
        }

        // --- Load da Tela ---
        private void frmTelaPrincipal_Load(object sender, EventArgs e)
        {
            // ... (Seu código de animação do menu está ótimo) ...
            this.splicontPrincipal.Panel1Collapsed = false;
            this.splicontPrincipal.SplitterDistance = this.larguraMenuAberto;
            this.menuAberto = true;
            tsmMenuLateral.BackColor = Color.DarkSlateGray;

            // Preenche os dados do usuário logado
            if (this.usuarioLogado != null)
            {
                lblBoasVindas.Text = $"Olá, {this.usuarioLogado.nome_User}!";
                lblEmail.Text = this.usuarioLogado.email_User;
            }
            else
            {
                // (Fallback, como você já tinha)
                lblBoasVindas.Text = "Olá, Técnico!";
                lblEmail.Text = "email@exemplo.com";
            }

            CarregarChamados();

            // Verifica se o usuário foi recebido corretamente
            if (this.usuarioLogado != null)
            {
                // Preenche o Label de Boas Vindas
                // Use a propriedade correta do seu Model (ex: nome_User ou NomeCompleto)
                lblBoasVindas.Text = $"Olá, {this.usuarioLogado.nome_User}!";

                // Preenche o Label de Email
                // Use a propriedade correta do seu Model (ex: email_User)
                lblEmail.Text = this.usuarioLogado.email_User;
            }
            else
            {
                // Caso de teste (se abrir a tela sem login, por exemplo)
                lblBoasVindas.Text = "Olá, Técnico!";
                lblEmail.Text = "email@exemplo.com";
            }
        }
        

        // --- !! MÉTODO CARREGAR CHAMADOS (CORRIGIDO) !! ---
        private void CarregarChamados()
        {
            dgvChamados.Rows.Clear();
            try
            {
                // Pega o ID do técnico logado (do seu Model 'Usuario')
                int meuID = this.usuarioLogado.id_User; // Já pegamos isso antes, ótimo!

                // MODIFICADO: Passa 'meuID' para a BLL
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

                    // 3. Estiliza o botão "Solucionar"
                    // Verifica se 'tecResponsavel_Cham' (o ID) tem um valor
                    if (chamado.tecResponsavel_Cham.HasValue) // .HasValue verifica se o int? não é nulo
                    {
                        DataGridViewButtonCell cell = (DataGridViewButtonCell)dgvChamados.Rows[rowIndex].Cells["ColunaSolucionar"];
                        cell.Value = "Em Atendimento";

                        // Se o ID do responsável for o MEU ID (int == int)
                        if (chamado.tecResponsavel_Cham.Value == meuID)
                        {
                            cell.Style.BackColor = Color.CornflowerBlue; // Cor para "Meu"
                        }
                        else
                        {
                            cell.Style.BackColor = Color.Gray; // Cor para "De outro"
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

        // --- !! MÉTODO DE CLIQUE NA TABELA (CORRIGIDO) !! ---
        private void dgvChamados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int idDoChamado = Convert.ToInt32(dgvChamados.Rows[e.RowIndex].Cells["ColunaIdCham"].Value);
            string nomeColuna = dgvChamados.Columns[e.ColumnIndex].Name;

            Chamado chamadoClicado = _listaDeChamadosAtual.FirstOrDefault(c => c.id_Cham == idDoChamado);
            if (chamadoClicado == null) return;

            // --- Pega os dados CORRETOS para a lógica ---
            int meuID = this.usuarioLogado.id_User; // ID do técnico logado
            int? tecnicoID = chamadoClicado.tecResponsavel_Cham; // ID do responsável (pode ser nulo)
            string tecnicoNome = chamadoClicado.TecResponsavelNomeCompleto; // NOME do responsável (vem do JOIN)

            // --- LÓGICA DO BOTÃO "SOLUCIONAR" ---
            if (nomeColuna == "ColunaSolucionar")
            {
                // Caso 1: Chamado está LIVRE (!tecnicoID.HasValue == "é nulo")
                if (!tecnicoID.HasValue)
                {
                    DialogResult confirmacao = MessageBox.Show(
                        "Deseja atribuir este chamado a você e iniciar a solução?",
                        "Confirmar Ação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmacao == DialogResult.Yes)
                    {
                        // Tenta "pegar" o chamado no banco usando o MEU ID
                        bool sucesso = chamadoBLL.AtribuirChamado(idDoChamado, meuID);

                        if (sucesso)
                        {
                            AbrirDetalhes(idDoChamado);
                        }
                        else
                        {
                            MessageBox.Show("Este chamado acabou de ser pego por outro técnico. A lista será atualizada.", "Conflito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        CarregarChamados(); // Atualiza a lista
                    }
                }
                // Caso 2: Chamado está pego por MIM (compara ID com ID)
                else if (tecnicoID.Value == meuID)
                {
                    AbrirDetalhes(idDoChamado);
                }
                // Caso 3: Chamado está pego por OUTRO TÉCNICO
                else
                {
                    // !! RESPOSTA AQUI !! Mostra o NOME (que veio do JOIN)
                    MessageBox.Show("Este chamado já está sendo solucionado por: " + tecnicoNome, "Chamado Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            // --- LÓGICA DO BOTÃO "VER DETALHES" ---
            if (nomeColuna == "ColunaDetalhes")
            {
                if (tecnicoID.HasValue && tecnicoID.Value == meuID)
                {
                    AbrirDetalhes(idDoChamado);
                }
                else if (!tecnicoID.HasValue) // Se estiver livre
                {
                    MessageBox.Show("Você deve primeiro clicar em 'Solucionar' para atribuir este chamado a você.", "Ação Necessária", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // Se for de outro técnico
                {
                    // !! RESPOSTA AQUI !! Mostra o NOME
                    MessageBox.Show("Este chamado está sendo solucionado por: " + tecnicoNome + ". Você não pode ver os detalhes.", "Chamado Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // --- (O resto do seu código: AbrirDetalhes, ExecutarLogout, btnLogOut_Click, etc. está perfeito) ---

        private void AbrirDetalhes(int idDoChamado)
        {
            using (frmDetalhesChamado telaDeDetalhes = new frmDetalhesChamado(idDoChamado))
            {
                telaDeDetalhes.ShowDialog();
            }
            CarregarChamados();
        }

        private void ExecutarLogout()
        {
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            ExecutarLogout();
        }

        private void stripLogoutPrincipal_Click(object sender, EventArgs e)
        {
            ExecutarLogout();
        }

        private void frmTelaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (timerMenu.Enabled) return;
            menuAberto = !menuAberto;
            if (menuAberto)
            {
                splicontPrincipal.Panel1Collapsed = false;
            }
            timerMenu.Start();
        }

        private void timerMenu_Tick(object sender, EventArgs e)
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

        private void stripSobreHPrincipal_Click(object sender, EventArgs e)
        {
            string mensagem = "A HelpBox é uma empresa especializada em softwares para solucionamento interno de chamados...";
            string titulo = "Sobre a HelpBox";
            MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            // Cria e abre a tela do manual
            frmManual tela = new frmManual();
            tela.ShowDialog(); // Abre como uma janela "filha" (pop-up
        }

        private void stripManualPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void stripMSistemaPrincipal_Click(object sender, EventArgs e)
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