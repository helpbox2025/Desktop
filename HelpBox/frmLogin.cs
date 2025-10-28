using HelpBox.BLL; // Para usar UsuarioBLL
using HelpBox.Model; // Para usar Usuario

namespace HelpBox
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Define a mensagem e o título da caixa de diálogo
            string mensagem = "Deseja realmente sair?";
            string titulo = "Confirmação de Saída";

            // Define os botões que a caixa terá (Sim e Não) e um ícone de pergunta
            MessageBoxButtons botoes = MessageBoxButtons.YesNo;
            MessageBoxIcon icone = MessageBoxIcon.Question;

            // Mostra a caixa de diálogo e guarda o resultado do clique do usuário
            DialogResult resultado = MessageBox.Show(mensagem, titulo, botoes, icone);

            // verifica  se o botão clicado pelo usuário foi o "Sim"
            if (resultado == DialogResult.Yes)
            {
                // Se o usuário clicou em "Sim", fecha td
                Application.Exit();
            }
            // Se o usuário clicou em "Não", o código dentro do 'if' é ignorado, 
            // o método termina, e nada acontece,.
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = txtUsuario.Text.Trim(); // Pega o email do campo de usuário
            string senha = txtSenha.Text.Trim();    // Pega a senha

            // Cria uma instância da nossa camada de lógica de negócio
            UsuarioBLL usuarioBLL = new UsuarioBLL();

            try
            {
                // Chama o método de validação
                Usuario usuarioLogado = usuarioBLL.ValidarLoginTecnico(email, senha);

                // Verifica o resultado
                if (usuarioLogado != null)
                {
                    // SUCESSO! O usuário é um técnico válido.
                    MessageBox.Show($"Login bem-sucedido! Bem-vindo, {usuarioLogado.nome_User}!",
                                    "Autenticado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    // Abre a próxima tela (sua tela principal/dashboard)
                    // Passando o objeto 'usuarioLogado' para a próxima tela, se necessário
                    frmTelaPrincipal telaPrincipal = new frmTelaPrincipal(usuarioLogado);
                    this.Hide();
                    telaPrincipal.ShowDialog();
                    txtSenha.Clear(); // ADICIONADO: Limpa o campo de senha ao retornar do logout.
                    this.Show(); // Mostra o login dnv qnd fechar a TelaPrincipal
                }
                else
                {
                    // FALHA! Usuário/senha inválidos ou não é um técnico.
                    MessageBox.Show("Email ou senha inválidos, ou o usuário não tem permissão de técnico.",
                                    "Falha no Login",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    txtSenha.Clear(); // Limpa a senha
                    txtUsuario.Focus(); // Coloca o foco de volta no usuário
                }
            }
            catch (Exception ex)
            {
                // Captura erros inesperados (ex: falha na conexão que a BLL/DAL não tratou)
                MessageBox.Show($"Ocorreu um erro inesperado durante o login: {ex.Message}",
                                "Erro Crítico",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void pboxLogoHP_Click(object sender, EventArgs e)
        {

        }
    }
}
