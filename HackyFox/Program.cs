namespace HackyFox
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
<<<<<<< HEAD
            Application.Run(new Form1()); //Cambiar al forms que quieras revisar
=======
            Application.Run(new Menu()); //Cambiar al forms que quieras revisar
>>>>>>> 953d28082e617c84c972a12410ad8c04d8a7e3e7

        }
    }
}