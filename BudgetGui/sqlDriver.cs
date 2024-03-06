using System;
using System.Data.SQLite;
using System.Reflection;

public class sqlDriver
{

    private string userTableSql = @"CREATE TABLE _user(
                                    userId INT PRIMARY KEY,
                                    fName VARCHAR(50),
                                    lName VARCHAR(50),
                                    DOB VARCHAR(10),
                                    streetnum INT,
                                    street VARCHAR(100),
                                    city VARCHAR(50),
                                    zip INT,
                                    age INT, --should be changed to derived attribute
                                    profilePicture VARCHAR(100) --No idea how to do this unless its holding the link to the picture
                                );";
    private string messageTableSql = @"CREATE TABLE _message(
                                    sender INT,
                                    timeDate DATE,
                                    recipient INT,
                                    text1 VARCHAR(255),
                                    PRIMARY KEY(sender, timeDate),
                                    CONSTRAINT fk_sender FOREIGN KEY(sender) REFERENCES _user(userId),
                                    CONSTRAINT fk_recipient FOREIGN KEY(recipient) REFERENCES _user(userId)
                                );";
    private string itemTableSql = @"CREATE TABLE item(
                                    itemId INT PRIMARY KEY,
                                    sellerId INT,
                                    postDate DATE,
                                    title VARCHAR(100),
                                    description VARCHAR(255),
                                    photoUrl VARCHAR(255),
                                    basePrice DECIMAL(10,2),
                                    endDate DATE,
                                    minimum DECIMAL(10,2),
                                    buyerId INT,
                                    rating DECIMAL(2,1),
                                    text1 VARCHAR(255),
                                    CONSTRAINT fk_seller FOREIGN KEY(sellerId) REFERENCES _user(userId),
                                    CONSTRAINT fk_buyerId FOREIGN KEY(buyerId) REFERENCES _user(userId)
                                );";
    private string logsTableSql = @"CREATE TABLE logs(
                                    logId INT PRIMARY KEY,
                                    userId INT,
                                    timeDate DATE,
                                    type VARCHAR(50),
                                    dataJson VARCHAR(255),
                                    CONSTRAINT fk_userId FOREIGN KEY(userId) REFERENCES _user(userId)
                                );";
    private string bidsTableSql = @"CREATE TABLE bids(
                                    _user INT,
                                    itemId INT,
                                    bidDate DATE,
                                    currency VARCHAR(50),
                                    amount DECIMAL(10,2),
                                    CONSTRAINT pk_bids PRIMARY KEY(_user, itemId, bidDate),
                                    CONSTRAINT fk_user FOREIGN KEY(_user) REFERENCES _user(userId),
                                    CONSTRAINT fk_itemId FOREIGN KEY(itemId) REFERENCES item(itemId)
                                );";

    private string databaseFileName = "budgetList.db";
    private string databaseFilePath;

    public sqlDriver()
    {
        databaseFilePath = getDatabaseFilePath(databaseFileName);
    }

    public void databaseStartup() {
        createDatabaseIfNotExists(databaseFilePath);

        createTableIfNotExists(databaseFilePath, "_user", userTableSql);
        createTableIfNotExists(databaseFilePath, "_message", messageTableSql);
        createTableIfNotExists(databaseFilePath, "item", itemTableSql);
        createTableIfNotExists(databaseFilePath, "logs", logsTableSql);
        createTableIfNotExists(databaseFilePath, "bids", bidsTableSql);
    }

    public void createDatabaseIfNotExists(string databaseFilePath) {
        if (!File.Exists(databaseFilePath)) {
            SQLiteConnection.CreateFile(databaseFilePath);
            Console.WriteLine($"Database '{databaseFilePath}' created successfully.");
        } else {
            Console.WriteLine($"Database '{databaseFilePath}' already exists.");
        }
    }

    public void createTableIfNotExists(string databaseFilePath, string tableName, string createTableSql) {
        bool tableExists = false;

        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath}")) {
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand($"SELECT COUNT(*) FROM sqlite_master WHERE type='table' AND name='{tableName}'", connection)) {
                int count = Convert.ToInt32(command.ExecuteScalar());
                tableExists = count > 0;
            }
        }

        if (!tableExists) {
            using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath}")) {
                connection.Open();
                using (SQLiteCommand createTableCommand = new SQLiteCommand(createTableSql, connection)) {
                    createTableCommand.ExecuteNonQuery();
                }
            }
            Console.WriteLine("Table created successfully.");
        } else {
            Console.WriteLine("Table already exists.");
        }
    }

    public string getDatabaseFilePath(string databaseFileName) {
        string assemblyLocation = Assembly.GetExecutingAssembly().Location;
        string assemblyDirectory = Path.GetDirectoryName(assemblyLocation);
        return Path.Combine(assemblyDirectory, databaseFileName);
    }
}