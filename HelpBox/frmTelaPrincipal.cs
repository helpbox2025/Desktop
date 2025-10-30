using HelpBox.Model;
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
using System.Collections.Generic;
namespace HelpBox
{
    public partial class frmTelaPrincipal : Form
    {
        private ChamadoBLL chamadoBLL = new ChamadoBLL();
        // Variáveis para controlar a animação do menu
        private bool menuAberto = false; // Começa com o estado "fechado"
        private int larguraMenuAberto = 280; // Largura do menu quando estiver aberto
        private int larguraMenuFechado = 0; // Largura do menu quando estiver fechado
        private int passoAnimacao = 30; // Velocidade do deslize em pixels

        // Variável para guardar os dados do usuário que logou
        private Usuario usuarioLogado;

        public frmTelaPrincipal(Usuario usuario)
        {
            InitializeComponent();
            this.usuarioLogado = usuario; // Guarda o usuário recebido na variável
        }
        private void frmTelaPrincipal_Load(object sender, EventArgs e)
        {
            // Chama o nosso método para preencher a grade assim que a tela carregar
            // CarregarDadosFicticios(); // Assumindo que você agora tem um método CarregarChamados() real
            CarregarChamados(); // Chamando o método para carregar dados reais (provavelmente)

            // ------------------- MUDANÇAS PARA O MENU INICIAR ABERTO -------------

            // 1. Garante que o painel esquerdo NÃO comece colapsado/escondido.
            this.splicontPrincipal.Panel1Collapsed = false;

            // 2. Define a largura inicial do menu para a largura total de "aberto".
            //    (Lembre-se que 'larguraMenuAberto' é a variável que definimos com o valor 280)
            this.splicontPrincipal.SplitterDistance = this.larguraMenuAberto;

            // 3. Define o estado inicial da nossa variável de controle como "aberto".
            this.menuAberto = true;

            tsmMenuLateral.BackColor = Color.DarkSlateGray;

            // --- CÓDIGO PARA EXIBIR DADOS DO USUÁRIO LOGADO ---
            // Verifica se recebemos os dados do usuário da tela de login
            if (this.usuarioLogado != null)
            {
                // Atualiza o Label de boas-vindas com o nome do usuário
                // Certifique-se que 'nome_User' é a propriedade correta no seu Model
                lblBoasVindas.Text = $"Olá, {this.usuarioLogado.nome_User}!";

                // ---- LINHA ADICIONADA ----
                lblEmail.Text = this.usuarioLogado.email_User; // ADICIONADO: Atualiza o Label de email com o email do usuário logado.
            }
            else
            {
                // Opcional: Define textos padrão caso o usuário não seja recebido
                lblBoasVindas.Text = "Olá, Técnico!";
                lblEmail.Text = "email@exemplo.com";
            }
        }

        private void ExecutarLogout()
        {
           
            this.Close(); // dispara o FORM Closing
          
        }
        private void CarregarChamados()
        {
            // Limpa a tabela antes de carregar
            dgvChamados.Rows.Clear();

            try
            {
                // CHAMA A BLL!
                List<Chamado> listaDeChamados = chamadoBLL.ListarChamadosParaGrid();

                // Agora, preenche o grid (dgvChamados)
                foreach (var chamado in listaDeChamados)
                {
                    dgvChamados.Rows.Add(
                        chamado.id_Cham,
                        chamado.categoria_Cham,
                        chamado.titulo_Cham, // O "Assunto"
                        chamado.prioridade_Cham,
                        chamado.dataAbertura_Cham.ToShortDateString(), // Formata a data
                        chamado.status_Cham
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar chamados: " + ex.Message);
            }
        }

        /*private void CarregarDadosFicticios()
        {
            // Limpa apenas as LINHAS existentes para não acumular dados a cada teste
            dgvChamados.Rows.Clear();

            // DADOS FICTÍCIOS
            // A ordem dos dados que adicionamos abaixo deve ser a mesma das suas colunas de texto:
            // ID Chamado, Categoria, Assunto, Prioridade, Data de Abertura, Status

            // Linha 1
            dgvChamados.Rows.Add("020310", "Software", "Erro ao emitir nota fiscal", "Média", "06/10/2025", "Aberto");

            // Linha 2
            dgvChamados.Rows.Add("232665", "Software", "Sistema lento após atualização", "Alta", "08/10/2025", "Andamento");

            // Linha 3
            dgvChamados.Rows.Add("023694", "Hardware", "Impressora da recepção não funciona", "Baixa", "07/10/2025", "Aberto");

            // Linha 4
            dgvChamados.Rows.Add("558963", "Hardware", "Monitor do estoque está piscando", "Média", "07/10/2025", "Aberto");

            // Linha 5
            dgvChamados.Rows.Add("785321", "Software", "Login de novo funcionário não funciona", "Alta", "08/10/2025", "Aberto");
        }*/

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Se o timer já estiver rodando a animação, não faz nada (evita cliques duplos)
            if (timerMenu.Enabled)
                return;

            // Inverte o estado do menu (se estava fechado, agora está abrindo, e vice-versa)
            menuAberto = !menuAberto;

            // Se o menu for abrir, primeiro precisamos garantir que o painel está visível
            if (menuAberto)
            {
                splicontPrincipal.Panel1Collapsed = false;
            }

            // Inicia o timer, que vai começar a executar a animação no evento Tick
            timerMenu.Start();
        }

        private void timerMenu_Tick(object sender, EventArgs e)
        {
            // Usa o nome do seu SplitContainer: splicontPrincipal
            if (menuAberto)
            {
                // --- LÓGICA PARA ABRIR O MENU ---
                // Se a largura atual for menor que a largura desejada...
                if (splicontPrincipal.SplitterDistance < larguraMenuAberto)
                {
                    // ...aumenta a largura em "passoAnimacao" pixels
                    splicontPrincipal.SplitterDistance += passoAnimacao;
                }
                else
                {
                    // Se já atingiu ou passou da largura desejada, trava no alvo e para o timer
                    splicontPrincipal.SplitterDistance = larguraMenuAberto;
                    timerMenu.Stop();
                    tsmMenuLateral.BackColor = Color.DarkSlateGray; // ADICIONADO: Pinta o fundo do botão para indicar que o menu está aberto.
                }
            }
            else
            {
                // --- LÓGICA PARA FECHAR O MENU ---
                // Se a largura atual for maior que a largura mínima...

                // Agora, ele verifica se o *próximo passo* da animação ainda será maior que o alvo.
                if ((splicontPrincipal.SplitterDistance - passoAnimacao) > larguraMenuFechado)
                {
                    // ...diminui a largura em "passoAnimacao" pixels
                    splicontPrincipal.SplitterDistance -= passoAnimacao;
                }
                else
                {
                    // Se já atingiu ou passou da largura mínima, trava no alvo, esconde o painel e para o timer
                    splicontPrincipal.SplitterDistance = larguraMenuFechado;
                    timerMenu.Stop();
                    splicontPrincipal.Panel1Collapsed = true; // Esconde completamente no final
                    tsmMenuLateral.BackColor = Color.Transparent; // ADICIONADO: Limpa a cor de fundo para indicar que o menu está fechado.
                }
            }
        }

        private void stripSobreHPrincipal_Click(object sender, EventArgs e)
        {
            // Define o texto que será exibido na mensagem
            string mensagem = "A HelpBox é uma empresa especializada em softwares para solucionamento interno de chamados relacionados à problemas com hardware e software. Caso queira saber mais ou abrir um chamado, acesse: ";

            // Define o título da janela da mensagem
            string titulo = "Sobre a HelpBox";

            // Mostra a caixa de mensagem com o botão OK e o ícone de Informação
            MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvChamados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignora clique no cabeçalho

            string nomeColuna = dgvChamados.Columns[e.ColumnIndex].Name;

            // (Os nomes "ColunaSolucionar" e "ColunaDetalhes" vêm do seu .Designer.cs)
            if (nomeColuna == "ColunaSolucionar" || nomeColuna == "ColunaDetalhes")
            {
                // Pega o ID (que agora é um int) da coluna "ColunaIdCham"
                int idDoChamado = Convert.ToInt32(dgvChamados.Rows[e.RowIndex].Cells["ColunaIdCham"].Value);

                // ** IMPORTANTE **
                // Você precisa mudar seu 'frmDetalhesChamado' para aceitar um INT, não uma string
                // Ex: public frmDetalhesChamado(int idChamado)
                frmDetalhesChamado telaDeDetalhes = new frmDetalhesChamado(idDoChamado);

                telaDeDetalhes.ShowDialog();

                // Atualiza a lista depois de fechar a tela de detalhes
                CarregarChamados();
            }
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
            // Verifica se o motivo do fechamento foi o usuário clicando no 'X' 
            // (ou Alt+F4, etc.). Isso evita que a mensagem apareça se o programa 
            // estiver fechando por outro motivo.
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // 1. Prepara a mensagem de confirmação (mesma lógica do botão Logout)
                string mensagem = "Deseja realmente deslogar?";
                string titulo = "Confirmação de Saída";
                MessageBoxButtons botoes = MessageBoxButtons.YesNo;
                MessageBoxIcon icone = MessageBoxIcon.Question;

                // 2. Mostra a caixa de diálogo e guarda a resposta
                DialogResult resultado = MessageBox.Show(mensagem, titulo, botoes, icone);

                // 3. Verifica se o usuário clicou em "NÃO"
                if (resultado == DialogResult.No)
                {
                    // Se clicou em "Não", CANCELA o evento de fechamento da janela.
                    e.Cancel = true;
                }
                // Se o usuário clicou em "Sim", a propriedade e.Cancel continua 'false' (o padrão),
                // e o formulário será fechado normalmente, retornando para a tela de login.
            }
        }
    }
}