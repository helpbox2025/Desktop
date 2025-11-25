using HelpBox.BLL;
using HelpBox.Model;

namespace HelpBox
{
    public partial class frmLogin : Form
    {
        public frmLogin() // Inicializa os componentes visuais da tela de login.
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        // Exibe confirmação e encerra toda a aplicação se o usuário clicar em 'Sim'.
        private void btnSair_Click(object sender, EventArgs e) 
        {
            string mensagem = "Deseja realmente sair?";
            string titulo = "Confirmação de Saída";
            MessageBoxButtons botoes = MessageBoxButtons.YesNo;
            MessageBoxIcon icone = MessageBoxIcon.Question;
            DialogResult resultado = MessageBox.Show(mensagem, titulo, botoes, icone);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Valida as credenciais do técnico e abre a tela
        // principal se o login for bem-sucedido.
        // Método que é executado quando o botão "Entrar" (btnEntrar) é clicado
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // remove espaços em branco no início e fim
            string email = txtUsuario.Text.Trim();

            // remove espaços em branco no início e fim
            string senha = txtSenha.Text.Trim();

 
            UsuarioBLL usuarioBLL = new UsuarioBLL();

          
            try
            {
                Usuario usuarioLogado = usuarioBLL.ValidarLoginTecnico(email, senha);

                if (usuarioLogado != null)
                {
                    MessageBox.Show($"Login bem-sucedido! Bem-vindo, " +
                        $"{usuarioLogado.nome_User}!",
                        "Autenticado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    frmTelaPrincipal telaPrincipal = new frmTelaPrincipal(usuarioLogado);

                    // Oculta o formulário de login atual (this)
                    this.Hide();

                    // bloqueia o acesso a outras janelas da aplicação
                    // até ser fechada
                    telaPrincipal.ShowDialog();

                    // Limpa o campo de senha após o retorno da
                    // tela principal (para segurança)
                    txtSenha.Clear();

                    // Torna o formulário de login atual (this)
                    // visível novamente após o fechamento da tela principal
                    this.Show();
                }
                // Se usuarioLogado for nulo (login falhou)
                else
                {
                    MessageBox.Show("Email ou senha inválidos, ou o " +
                                    "usuário não tem permissão de técnico.",
                                    "Falha no Login",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    // Limpa o campo de senha
                    txtSenha.Clear();

                    // Define o foco de volta para o campo de
                    // email/usuário, para facilitar a correção
                    txtUsuario.Focus();
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show($"Ocorreu um erro inesperado durante o " +
                                $"login: {ex.Message}",
                                "Erro Crítico",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void pboxLogoHP_Click(object sender, EventArgs e)
        {

        }
        private void pnLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
