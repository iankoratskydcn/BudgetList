using System;
using Microsoft.Data.SqlClient;

public class sqlDriver
{
    public sqlDriver()
    {
    }

    public void createDatabaseIfNotExists(string connectionString, string databaseName) {
        bool databaseExists = checkIfDatabaseExists(connectionString, databaseName);

        if (!databaseExists) {
            createDatabase(connectionString, databaseName);
            Console.WriteLine($"Database '{databaseName}' created successfully.");
        }
        else {
            Console.WriteLine($"Database '{databaseName}' already exists.");
        }
    }

    private bool checkIfDatabaseExists(string connectionString, string databaseName) {
        string query = $"SELECT COUNT(*) FROM sys.databases WHERE name = '{databaseName}'";

        using (SqlConnection connection = new SqlConnection(connectionString)) {
            connection.Open();
            using (SqlCommand command = new SqlCommand(query, connection)) {
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
    }

    private void createDatabase(string connectionString, string databaseName) {
        string query = $"CREATE DATABASE [{databaseName}]";

        using (SqlConnection connection = new SqlConnection(connectionString)) {
            connection.Open();
            using (SqlCommand command = new SqlCommand(query, connection)) {
                command.ExecuteNonQuery();
            }
        }
    }

    public void createTableIfNotExists(string connectionString, string tableName, string createTableSql) {
        bool tableExists = false;
        string query = $"SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '{tableName}'";
        using (SqlConnection connection = new SqlConnection(connectionString)) {
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            int count = (int)command.ExecuteScalar();
            if (count > 0) {
                tableExists = true;
            }
        }

        if (!tableExists) {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand createTableCommand = new SqlCommand(createTableSql, connection);
                createTableCommand.ExecuteNonQuery();
            }
            Console.WriteLine("Table created successfully.");
        }
        else {
            Console.WriteLine("Table already exists.");
        }
    }
}