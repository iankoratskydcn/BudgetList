using System.Security.Cryptography.X509Certificates;

namespace BudgetGui
{
    internal static class Program
    {
        //The main entry point for the application.
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            sqlDriver sqlDriver = new sqlDriver();
            sqlDriver.createDatabaseIfNotExists();

            Form1 form1 = new Form1();
            Application.Run(form1);
        }
    }
}