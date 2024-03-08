using System;
using System.Data.SQLite;
using System.Reflection;

public class sqlDriver
{

    private string databaseFileName = "budgetList.db";
    private string tablesFileName = "tables.sql";
    private string databaseFilePath;
    private string sqlFilePath;

    public sqlDriver() {
        databaseFilePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), databaseFileName);
        sqlFilePath = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\sql", tablesFileName);
    }

    public void databaseStartup() {
        createDatabaseIfNotExists(databaseFilePath, sqlFilePath);
    }

    public void createDatabaseIfNotExists(string databaseFilePath, string sqlFilePath) {
        if (!File.Exists(databaseFilePath)) {
            SQLiteConnection.CreateFile(databaseFilePath);
            Console.WriteLine($"Database '{databaseFilePath}' created successfully.");
            string sqlCommands = File.ReadAllText(sqlFilePath);
            try {
                using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;")) {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(sqlCommands, connection)) {
                        command.ExecuteNonQuery();
                        Console.WriteLine("SQL commands executed successfully.");
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