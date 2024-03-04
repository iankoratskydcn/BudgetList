using System.Security.Cryptography.X509Certificates;

// To customize application configuration such as set high DPI settings or default font,
// see https://aka.ms/applicationconfiguration.

namespace BudgetGui
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            sqlDriver sqlDriver = new sqlDriver();
            //sqlDriver.databaseStartup(); //Not complete yet

            Form1 form1 = new Form1();
            Application.Run(form1);
        }
    }
}