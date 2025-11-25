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

        // Inicializa a tela e recebe o objeto do usuário logado.
        public frmTelaPrincipal(Usuario usuario) 
        {
            InitializeComponent();
            this.usuarioLogado = usuario;
        }

        // Configura o layout inicial, exibe mensagem de
        // boas-vindas e carrega a lista de chamados.
        private void frmTelaPrincipal_Load(object sender, EventArgs e) 
        {
            this.splicontPrincipal.Panel1Collapsed = false;
            this.splicontPrincipal.SplitterDistance = this.larguraMenuAberto;
            this.menuAberto = true;
            tsmMenuLateral.BackColor = Color.DarkSlateGray;

            if (this.usuarioLogado != null)
            {
                lblBoasVindas.Text = $"Olá, {this.usuarioLogado.nome_User}!";
                lblEmail.Text = this.usuarioLogado.email_User;
                lblDepartamento.Text = $"Departamento: {this.usuarioLogado.departamento_User}";
            }
            else
            {
                lblBoasVindas.Text = "Olá, Técnico!";
                lblEmail.Text = "email@exemplo.com";
            }

            CarregarChamados();

        }

        // Busca os chamados no banco, preenche a tabela
        // e define as cores dos botões de ação.
        private void CarregarChamados()
        {
            dgvChamados.Rows.Clear();

            try
            {
                // Obtém o ID do usuário logado
                int meuID = this.usuarioLogado.id_User;

                // Busca a lista de chamados do usuário para exibir no grid
                _listaDeChamadosAtual = chamadoBLL.ListarChamadosParaGrid(meuID);

                // Percorre cada chamado retornado
                foreach (var chamado in _listaDeChamadosAtual)
                {
                    // Adiciona uma nova linha no DataGridView com os dados do chamado
                    int rowIndex = dgvChamados.Rows.Add(
                        chamado.id_Cham,
                        chamado.categoria_Cham,
                        chamado.titulo_Cham,
                        chamado.prioridade_Cham,
                        chamado.dataAbertura_Cham.ToShortDateString(), // formata a data
                        chamado.status_Cham,
                        chamado.TecResponsavelNomeCompleto 
                    );

                    // Se o chamado já tem um técnico responsável
                    if (chamado.tecResponsavel_Cham != null)
                    {
                        // Obtém a célula do botão "Solucionar" da linha adicionada
                        DataGridViewButtonCell cell = (DataGridViewButtonCell)dgvChamados.Rows[rowIndex].Cells["ColunaSolucionar"];

                        // Altera o texto do botão para indicar que está em atendimento
                        cell.Value = "Em Atendimento";

                        // Se o técnico responsável for o próprio usuário logado
                        if (chamado.tecResponsavel_Cham == meuID)
                        {
                            // Destaque azul indicando que o chamado é do usuário
                            cell.Style.BackColor = Color.CornflowerBlue;
                        }
                        else
                        {
                            // Caso contrário, fica cinza indicando que
                            // pertence a outro técnico
                            cell.Style.BackColor = Color.Gray;
                        }
                        // Define a cor do texto do botão como
                        // branco para boa visualização
                        cell.Style.ForeColor = Color.White;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar chamados: " + ex.Message);
            }
        }

        // Gerencia os cliques nos botões da tabela
        // (Solucionar/Detalhes) e valida se o técnico pode acessar o chamado.
        private void dgvChamados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignora cliques no header (linha -1)
            if (e.RowIndex < 0) return;

            // Obtém o ID do chamado da linha clicada
            int idDoChamado = Convert.ToInt32(dgvChamados.Rows[e.RowIndex]
                .Cells["ColunaIdCham"].Value);

            // Descobre o nome da coluna que foi clicada
            string nomeColuna = dgvChamados.Columns[e.ColumnIndex].Name;

            // Busca o chamado correspondente na lista carregada anteriormente
            Chamado chamadoClicado = _listaDeChamadosAtual
                .FirstOrDefault(c => c.id_Cham == idDoChamado);
            if (chamadoClicado == null) return;

            // Obtém o ID do usuário logado
            int meuID = this.usuarioLogado.id_User;

            // ID do técnico responsável pelo chamado (se houver)
            int? tecnicoID = chamadoClicado.tecResponsavel_Cham;

            // Nome do técnico responsável, usado em mensagens
            string tecnicoNome = chamadoClicado.TecResponsavelNomeCompleto;

            // Se o usuário clicou no botão "Solucionar"
            if (nomeColuna == "ColunaSolucionar")
            {
                // Caso o chamado ainda não tenha técnico responsável
                if (!tecnicoID.HasValue)
                {
                    // Confirmação antes de atribuir o chamado ao usuário
                    DialogResult confirmacao = MessageBox.Show(
                        "Deseja atribuir este chamado a você e iniciar a solução?",
                        "Confirmar Ação", MessageBoxButtons.YesNo, 
                        MessageBoxIcon.Question);

                    if (confirmacao == DialogResult.Yes)
                    {
                        // Tenta atribuir o chamado ao usuário logado
                        bool sucesso = chamadoBLL.AtribuirChamado(idDoChamado, meuID);

                        if (sucesso)
                        {
                            // Se conseguiu atribuir, abre os detalhes do chamado
                            AbrirDetalhes(idDoChamado);
                        }
                        else
                        {
                            // Caso outro técnico tenha pegado ao mesmo tempo
                            MessageBox.Show("Este chamado acabou de ser pego por outro técnico. " +
                                "A lista será atualizada.", "Conflito", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        // Atualiza o grid de chamados
                        CarregarChamados();
                    }
                }
                // Se o chamado já está atribuído ao usuário atual
                else if (tecnicoID.Value == meuID)
                {
                    // Abre diretamente os detalhes
                    AbrirDetalhes(idDoChamado);
                }
                else
                {
                    // Se já tem técnico e não é o usuário atual
                    MessageBox.Show("Este chamado já está sendo solucionado " +
                        "por: " + tecnicoNome, "Chamado Bloqueado", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            // Se o clique foi no botão/coluna "Detalhes"
            if (nomeColuna == "ColunaDetalhes")
            {
                // Usuário só pode abrir detalhes se ele for o responsável pelo chamado
                if (tecnicoID.HasValue && tecnicoID.Value == meuID)
                {
                    AbrirDetalhes(idDoChamado);
                }
                // Se o chamado não tem técnico ainda
                else if (!tecnicoID.HasValue)
                {
                    MessageBox.Show("Você deve primeiro clicar em 'Solucionar' " +
                        "para atribuir este chamado a você.", 
                        "Ação Necessária", MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                }
                else
                {
                    // Se o chamado é de outro técnico, impede acesso
                    MessageBox.Show("Este chamado está sendo solucionado por: " +
                        "" + tecnicoNome + ". Você não pode ver os detalhes.", 
                        "Chamado Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        // Abre a janela de detalhes do chamado e atualiza a lista ao retornar.
        private void AbrirDetalhes(int idDoChamado) 
        {
            using (frmDetalhesChamado telaDeDetalhes = new frmDetalhesChamado(idDoChamado))
            {
                telaDeDetalhes.ShowDialog();
            }
            CarregarChamados();
        }

        // Fecha a tela atual para realizar o logout.
        private void ExecutarLogout() 
        {
            this.Close();
        }

        // Chama a função de logout ao clicar no botão.
        private void btnLogOut_Click(object sender, EventArgs e) 
        {
            ExecutarLogout();
        }

        // Chama a função de logout através do menu superior.
        private void stripLogoutPrincipal_Click(object sender, EventArgs e) 
        {
            ExecutarLogout();
        }

        // Exibe confirmação ao tentar fechar a janela e cancela se o usuário negar.
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

        // Alterna o estado do menu lateral (abrir/fechar) e inicia a animação.
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

        // Controla a animação de deslize do menu lateral a cada "tick" do temporizador.
        private void timerMenu_Tick(object sender, EventArgs e)
        {
            // Verifica se o menu deve abrir (true) ou fechar (false)
            if (menuAberto)
            {
                // Enquanto a largura atual for menor que a
                // largura desejada do menu aberto
                if (splicontPrincipal.SplitterDistance < larguraMenuAberto)
                {
                    // Aumenta gradualmente o tamanho
                    // do painel (animação de abertura)
                    splicontPrincipal.SplitterDistance += passoAnimacao;
                }
                else
                {
                    // Quando atingir a largura final, fixa o valor
                    splicontPrincipal.SplitterDistance = larguraMenuAberto;

                    timerMenu.Stop();

                    // Muda a cor do botão/menu para indicar que está aberto
                    tsmMenuLateral.BackColor = Color.DarkSlateGray;
                }
            }
            else
            {
                // Caso o menu esteja fechando, diminui a largura gradualmente
                if ((splicontPrincipal.SplitterDistance - passoAnimacao) > larguraMenuFechado)
                {
                    splicontPrincipal.SplitterDistance -= passoAnimacao;
                }
                else
                {
                    // Define a largura mínima do menu fechado
                    splicontPrincipal.SplitterDistance = larguraMenuFechado;

                    // Finaliza a animação
                    timerMenu.Stop();

                    // Colapsa o painel esquerdo para ocultá-lo totalmente
                    splicontPrincipal.Panel1Collapsed = true;

                    // Volta a cor original do botão/menu
                    tsmMenuLateral.BackColor = Color.Transparent;
                }
            }
        }


        // Exibe informações sobre a empresa HelpBox.
        private void stripSobreHPrincipal_Click(object sender, EventArgs e) 
        {
            string mensagem = "A HelpBox é uma empresa especializada em softwares para solucionamento interno de chamados relacionados à problemas com hardware e software. Caso queira saber mais ou abrir um chamado, " +
                "acesse a versão Web!";
            string titulo = "Sobre a HelpBox";
            MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void panelLogo_Paint(object sender, PaintEventArgs e) 
        {

        }

        // Abre a janela do Manual do Sistema pelo botão lateral.
        private void btnManual_Click(object sender, EventArgs e) 
        {
            frmManual tela = new frmManual();
            tela.ShowDialog(); 
        }
        private void stripManualPrincipal_Click(object sender, EventArgs e)
        {

        }

        // Abre a janela do Manual do Sistema pelo menu superior.
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