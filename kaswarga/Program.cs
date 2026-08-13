namespace kaswarga
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // UBAH BARIS INI: Ganti Form1() dengan nama Form Login Anda
            Login form = new Login();
            form.Show();

            Application.Run();
        }
    }
}