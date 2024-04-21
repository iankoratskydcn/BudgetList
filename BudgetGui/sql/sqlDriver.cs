using BudgetGui;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Reflection;
using System.Text;
using System.Windows.Input;
using System.Data.SQLite;
using System.Reflection;
using System.Runtime.InteropServices.JavaScript;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

public partial class sqlDriver
{

    private string databaseFileName = "budgetList.db";
    private string tablesFileName = "tables.sql";
    private string fakeDataFileName = "fakeData.sql";
    private string databaseFilePath;
    private string tablesFilePath;
    private string fakeDataFilePath;

    public string loggedInUsername;
    public string loggedInUserId;

    public sqlDriver()
    {
        databaseFilePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), databaseFileName);
        tablesFilePath = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\sql", tablesFileName);
        fakeDataFilePath = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\sql", fakeDataFileName);
    }

    public void createDatabaseIfNotExists()
    {
        if (!File.Exists(databaseFilePath))
        {
            SQLiteConnection.CreateFile(databaseFilePath);
            Console.WriteLine($"Database '{databaseFilePath}' created successfully.");
            string tablesSqlCommands = File.ReadAllText(tablesFilePath);
            string fakeDataSqlCommands = File.ReadAllText(fakeDataFilePath);
            using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(tablesSqlCommands, connection))
                {
                    command.ExecuteNonQuery();
                    Console.WriteLine("Table SQL commands executed successfully.");
                }
                using (SQLiteCommand command = new SQLiteCommand(fakeDataSqlCommands, connection))
                {
                    command.ExecuteNonQuery();
                    Console.WriteLine("Fake Data SQL commands executed successfully.");
                }
            }
        } else
        {
            Console.WriteLine($"Database '{databaseFilePath}' already exists.");
        }
    }

}