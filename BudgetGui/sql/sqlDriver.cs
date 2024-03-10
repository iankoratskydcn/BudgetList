using System;
using System.Data.SQLite;
using System.Reflection;

public class sqlDriver
{

    private string databaseFileName = "budgetList.db";
    private string tablesFileName = "tables.sql";
    private string fakeDataFileName = "fakeData.sql";
    private string databaseFilePath;
    private string tablesFilePath;
    private string fakeDataFilePath;

    public sqlDriver() {
        databaseFilePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), databaseFileName);
        tablesFilePath = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\sql", tablesFileName);
        fakeDataFilePath = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\sql", fakeDataFileName);
    }

    public void databaseStartup() {
        createDatabaseIfNotExists(databaseFilePath, tablesFilePath, fakeDataFilePath);
    }

    public void createDatabaseIfNotExists(string databaseFilePath, string tablesFilePath, string fakeDataFilePath) {
        if (!File.Exists(databaseFilePath)) {
            SQLiteConnection.CreateFile(databaseFilePath);
            Console.WriteLine($"Database '{databaseFilePath}' created successfully.");
            string tablesSqlCommands = File.ReadAllText(tablesFilePath);
            string fakeDataSqlCommands = File.ReadAllText(fakeDataFilePath);
            try {
                using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;")) {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(tablesSqlCommands, connection)) {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Table SQL commands executed successfully.");
                    }
                    using (SQLiteCommand command = new SQLiteCommand(fakeDataSqlCommands, connection)) {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Fake Data SQL commands executed successfully.");
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("Error executing SQL commands: " + ex.Message);
            }
        } else {
            Console.WriteLine($"Database '{databaseFilePath}' already exists.");
        }
    }
}