using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Data.SQLite;
using System.Reflection;
using System.Runtime.InteropServices.JavaScript;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

public partial class sqlDriver
{
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

    public int getUserIdByUsername(string username)
    {
        string query = @"SELECT userId FROM _user WHERE username = @username";

        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
        {
            connection.Open();

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                System.Data.SQLite.SQLiteDataReader reader = command.ExecuteReader();
                return reader.GetInt32(reader.GetOrdinal("userId"));
            }
        }
    }

}