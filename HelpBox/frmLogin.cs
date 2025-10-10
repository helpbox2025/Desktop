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

        }
    }
}
