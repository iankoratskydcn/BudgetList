using System.Security.Cryptography.X509Certificates;

namespace BudgetGui
{
    internal static class Program
    {

        public static string[] GlobalStrings { get; set; }

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Program.GlobalStrings = new string[2];

            sqlDriver _sqlDriver = new sqlDriver();
            _sqlDriver.createDatabaseIfNotExists();

            Form1 form1 = new Form1(_sqlDriver);
            Application.Run(form1);
        }
    }
}