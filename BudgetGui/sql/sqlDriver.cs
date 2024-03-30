using BudgetGui;
using System;
using System.Data.SQLite;
using System.Reflection;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

public class sqlDriver
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
        }
        else
        {
            Console.WriteLine($"Database '{databaseFilePath}' already exists.");
        }
    }

    public string login(string username, string password)
    {
        string query = "SELECT userId FROM _user WHERE username = @username AND _password = @password";
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
        {
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                object result = command.ExecuteScalar();
                if (result != null)
                {
                    loggedInUsername = username;
                    loggedInUserId = result.ToString();
                    return username;
                }
            }
        }
        return null;
    }

    public bool checkIfUsernameExists(string username)
    {
        string query = "SELECT COUNT(*) FROM _user WHERE username = @username";
        int count = 0;
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
        {
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                count = Convert.ToInt32(command.ExecuteScalar());
            }
        }
        return count > 0;
    }

    public void InsertUser(string firstName, string lastName, string username, string password, string email)
    {
        string maxUserIdQuery = "SELECT MAX(userId) FROM _user";
        string query = @"INSERT INTO _user (userId, fName, lName, username, _password, email) VALUES (@userId, @firstName, @lastName, @username, @password, @email)";
        int newUserId = 0;
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
        {
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(maxUserIdQuery, connection))
            {
                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    newUserId = Convert.ToInt32(result) + 1;
                }
            }
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@userId", newUserId);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@lastName", lastName);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@email", email);
                command.ExecuteNonQuery();
            }
        }
    }

    public List<string> checkForItemsBeingSold()
    {
        List<string> itemList = new List<string>();
        string query = @"
                    SELECT i.itemId, i.sellerId, i.title
                    FROM _user u
                    LEFT JOIN item i ON u.userId = i.sellerId
                    WHERE u.userId = @userId;
                    ";
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
        {
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@userId", Program.GlobalStrings[1]);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int? itemId = reader.IsDBNull(0) ? null : (int?)reader.GetInt32(0);
                        int? sellerId = reader.IsDBNull(1) ? null : (int?)reader.GetInt32(1);
                        string title = reader.IsDBNull(2) ? null : reader.GetString(2);

                        if (itemId == null || sellerId == null || title == null)
                        {
                            return null;
                        }

                        string itemInfo = $"ItemId: {itemId}, SellerId: {sellerId}, Title: {title}";
                        itemList.Add(itemInfo);
                    }
                }
                return itemList;
            }
        }
    }

    public void createNewItem(string title)
    {
        string maxItemIdQuery = "SELECT MAX(itemId) FROM item";
        string query = @"
                        INSERT INTO item (itemId, sellerId, title)
                        VALUES (@itemId, @sellerId, @title);
                        ";
        int newItemId = 1;
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
        {
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(maxItemIdQuery, connection))
            {
                object result = command.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    newItemId = Convert.ToInt32(result) + 1;
                }
            }
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@itemId", newItemId);
                command.Parameters.AddWithValue("@sellerId", Program.GlobalStrings[1]);
                command.Parameters.AddWithValue("@title", title);
                command.ExecuteNonQuery();
            }
        }
    }

    public void insertAddressToUser(string street, string city, string state, string zip)
    {
        string query = @"
                        UPDATE _user
                        SET street = @street,
                            city = @city,
                            state = @state,
                            zip = @zip
                        WHERE userId = @id;
                        ";
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
        {
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@street", street);
                command.Parameters.AddWithValue("@city", city);
                command.Parameters.AddWithValue("@state", state);
                command.Parameters.AddWithValue("@zip", zip);
                command.Parameters.AddWithValue("@id", Program.GlobalStrings[1]);
                command.ExecuteNonQuery();
            }
        }
    }

    public void executeDbInsertQuery(string query)
    {
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
        {
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }

}