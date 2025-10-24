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
            // Mantenha estas linhas de configuração!
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // ESTA é a única linha que deve executar a aplicação:
            Application.Run(new frmLogin());
        }
    }
}
    