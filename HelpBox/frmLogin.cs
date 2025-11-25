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

        private void btnSair_Click(object sender, EventArgs e) // Exibe confirmação e encerra toda a aplicação se o usuário clicar em 'Sim'.
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

        private void btnEntrar_Click(object sender, EventArgs e) // Valida as credenciais do técnico e abre a tela principal se o login for bem-sucedido.
        {
            string email = txtUsuario.Text.Trim();
            string senha = txtSenha.Text.Trim();

            UsuarioBLL usuarioBLL = new UsuarioBLL();

            try
            {
                Usuario usuarioLogado = usuarioBLL.ValidarLoginTecnico(email, senha);

                if (usuarioLogado != null)
                {
                    MessageBox.Show($"Login bem-sucedido! Bem-vindo, {usuarioLogado.nome_User}!",
                                    "Autenticado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    frmTelaPrincipal telaPrincipal = new frmTelaPrincipal(usuarioLogado);
                    this.Hide();
                    telaPrincipal.ShowDialog();
                    txtSenha.Clear();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Email ou senha inválidos, ou o usuário não tem permissão de técnico.",
                                    "Falha no Login",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    txtSenha.Clear();
                    txtUsuario.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro inesperado durante o login: {ex.Message}",
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
