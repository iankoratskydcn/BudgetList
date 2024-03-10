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
        createDatabaseIfNotExists();
    }

    public void createDatabaseIfNotExists() {
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

    public string login(string username, string password) {
        string query = "SELECT COUNT(*) FROM _user WHERE username = @username AND _password = @password";
        int count = 0;
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;")) {
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(query, connection)) {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                count = Convert.ToInt32(command.ExecuteScalar());
            }
        }
        if (count > 0) {
            return username;
        } else {
            return null;
        }
    }
}