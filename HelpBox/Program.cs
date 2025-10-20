namespace HelpBox
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /* // To customize application configuration such as set high DPI settings or default font,
             // see https://aka.ms/applicationconfiguration.
             ApplicationConfiguration.Initialize();
             //Application.Run(new frmTelaPrincipal());
             //Application.Run(new frmDetalhesChamado());
             Application.Run(new frmLogin());
            */
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. Cria uma instância da sua tela de login
            frmLogin telaLogin = new frmLogin();

            // 2. Mostra a tela de login como um "Dialog"
            // O código vai PAUSAR aqui até a tela de login ser fechada
            if (telaLogin.ShowDialog() == DialogResult.OK)
            {
                // 3. Se o DialogResult for "OK" (que definimos no botão Entrar),
                //    ele abre a Tela Principal.
                Application.Run(new frmTelaPrincipal());
            }

            // Se o usuário fechar a tela de login no "X" ou clicar em "Sair"
            // (que não retorna DialogResult.OK), a aplicação simplesmente termina.
        }
    }
}