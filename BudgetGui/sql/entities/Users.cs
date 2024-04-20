using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Data.SQLite;
using System.Reflection;
using System.Runtime.InteropServices.JavaScript;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data;

public partial class sqlDriver
{

    public void InsertUser(string firstName, string lastName, string username, string password, string email, string profile_pic)
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

    public JObject getUsersByCity(string city)
    {

        string query = @"SELECT * FROM _user WHERE city = @city";

        JObject obj;
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
        {
            connection.Open();

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@itemId", city);
                SQLiteDataReader reader = command.ExecuteReader();
                var r = Serialize(reader);
                obj = JObject.Parse(JsonConvert.SerializeObject(r));

            }
            return obj;
        }
    }
    public DataTable getUserById(int id)
    {
        string query = "SELECT * FROM _user WHERE userId = @userId";
        JObject obj;
        DataTable dataTable = new DataTable();
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
        {
            connection.Open();

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@userId", id);
                SQLiteDataReader reader = command.ExecuteReader();
                dataTable.Load(reader);
            }
        }
        return dataTable;
    }
}