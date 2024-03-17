using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices.JavaScript;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using static System.Windows.Forms.AxHost;

public partial class sqlDriver
{
    public void InsertItem( int itemId, int sellerId, DateTime postDate, string title, string description, string photoUrl, double basePrice, DateTime endDate, double minimum )
    {
        string query = @"INSERT INTO item (itemId, sellerId, postDate, title, description, photoUrl, basePrice, endDate, minimum) VALUES (@itemId, @sellerId, @postDate, @title, @description, @photoUrl, @basePrice, @endDate, @minimum)";

        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
        {
            connection.Open();

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@itemId", itemId);
                command.Parameters.AddWithValue("@sellerId", sellerId);
                command.Parameters.AddWithValue("@postDate", postDate);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@photoUrl", photoUrl);
                command.Parameters.AddWithValue("@basePrice", basePrice);
                command.Parameters.AddWithValue("@endDate", endDate);
                command.Parameters.AddWithValue("@minimum", minimum);
                command.ExecuteNonQuery();
            }
        }
    }
    public JObject getItemById(int itemId)
    {
        string query = @"SELECT * FROM item WHERE itemId = @itemId";

        JObject obj;
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
        {
            connection.Open();

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@itemId", itemId);
                System.Data.SQLite.SQLiteDataReader reader = command.ExecuteReader();
                var r = Serialize(reader);
                obj = JObject.Parse(JsonConvert.SerializeObject(r));

            }
            return obj;
        }
    }
    public JObject getItemsByCityAndCategory(string city, string category)
    {

        string query = @"SELECT * FROM item WHERE (sellerId IN (SELECT userId FROM _users WHERE city = @city)) AND category = @category";

        JObject obj;
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
        {
            connection.Open();

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@city", city);
                command.Parameters.AddWithValue("@category", category);
                System.Data.SQLite.SQLiteDataReader reader = command.ExecuteReader();
                var r = Serialize(reader);
                obj = JObject.Parse(JsonConvert.SerializeObject(r));

            }
            return obj;
        }
    }
    public JObject getItemsByStateAndCategory(string state, string category)
    {

        string query = @"SELECT * FROM item WHERE (sellerId IN (SELECT userId FROM _users WHERE state = @state)) AND category = @category";

        JObject obj;
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
        {
            connection.Open();

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@state", state);
                command.Parameters.AddWithValue("@category", category);
                System.Data.SQLite.SQLiteDataReader reader = command.ExecuteReader();
                var r = Serialize(reader);
                obj = JObject.Parse(JsonConvert.SerializeObject(r));

            }
            return obj;
        }
    }
    public JObject getItemsByZipAndCategory(string zip, string category)
    {

        string query = @"SELECT * FROM item WHERE (sellerId IN (SELECT userId FROM _users WHERE zip = @zip)) AND category = @category";

        JObject obj;
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
        {
            connection.Open();

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@zip", zip);
                command.Parameters.AddWithValue("@category", category);
                System.Data.SQLite.SQLiteDataReader reader = command.ExecuteReader();
                var r = Serialize(reader);
                obj = JObject.Parse(JsonConvert.SerializeObject(r));

            }
            return obj;
        }
    }
}
