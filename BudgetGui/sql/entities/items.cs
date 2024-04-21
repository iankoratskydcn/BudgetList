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
using BudgetGui;
using System.Data;
using BudgetGui.sql.entities;
using System.Data.SqlTypes;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

public partial class sqlDriver
{
    public void InsertItem(int itemId, int sellerId, DateTime postDate, string title, string description, string photoUrl, double basePrice, DateTime endDate, double minimum)
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

    public void save_item(int item_id)
    {
        // Create SQL command
        string insertSavedItemQuery = $@"
                                INSERT INTO savedItems (itemId, title, description, creatorUserId, savedUserId, postDate, currencyType, itemPrice) 
                                SELECT itemId, title, description, sellerId, @userid, postDate, currencyType, itemPrice 
                                FROM item 
                                WHERE itemId = @itemId;";

        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
        {
            connection.Open();

            using (SQLiteCommand command = new SQLiteCommand(insertSavedItemQuery, connection))
            {

                command.Parameters.AddWithValue("@userid", Program.GlobalStrings[1]);
                command.Parameters.AddWithValue("@itemId", item_id);

                command.ExecuteNonQuery();
                MessageBox.Show($"Item has been saved");
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
                string json = JsonConvert.SerializeObject(r, Newtonsoft.Json.Formatting.Indented);
                //MessageBox.Show(json);
                obj = JObject.Parse(json.Remove(json.Length - 1).Remove(0, 1));
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

    public void updated_bought_item(string itemId)
    {

        string updateBoughtItemQuery = @"UPDATE item SET buyerId = @buyerId, purchaseDate = @dateTime WHERE itemId = @itemId";

        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
        {
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(updateBoughtItemQuery, connection))
            {
                command.Parameters.AddWithValue("@itemId", Program.GlobalStrings[1]);
                command.Parameters.AddWithValue("@dateTime", DateTime.Today.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@itemId", itemId);

                command.ExecuteNonQuery();
            }
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

    public List<string> checkForItemsBeingSold()
    {
        List<string> itemList = new List<string>();
        string query = @"
                    SELECT i.itemId, i.sellerId, i.title
                    FROM _user u
                    LEFT JOIN item i ON u.userId = i.sellerId
                    WHERE u.userId = @userId AND i.buyerId IS NULL;
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

                        if (itemId == null)
                        {
                            return null;
                        }

                        string itemInfo = $"{title}";
                        itemList.Add(itemInfo);
                    }
                }
                return itemList;
            }
        }
    }

    public List<string> checkForItemsSold()
    {
        List<string> itemList = new List<string>();
        string query = @"
                    SELECT i.itemId, i.sellerId, i.title
                    FROM _user u
                    LEFT JOIN item i ON u.userId = i.sellerId AND i.buyerId IS NOT NULL
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

                        if (itemId == null)
                        {
                            return null;
                        }

                        string itemInfo = $"{title}";
                        itemList.Add(itemInfo);
                    }
                }
                return itemList;
            }
        }
    }

    public void createNewItem(string title, string description, string itemPrice)
    {
        string maxItemIdQuery = "SELECT MAX(itemId) FROM item";
        string query = @"
                        INSERT INTO item (itemId, sellerId, postDate, title, description, itemPrice)
                        VALUES (@itemId, @sellerId, @postDate, @title, @description, @itemPrice);
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
                command.Parameters.AddWithValue("@postDate", DateTime.Now);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@itemPrice", itemPrice);
                command.ExecuteNonQuery();
            }
        }
    }

    public void createNewItem(string title, string description, string photoUrl, string  itemPrice)
    {

        string maxItemIdQuery = "SELECT MAX(itemId) FROM item";
        string query = @"
                        INSERT INTO item (itemId, sellerId, postDate, title, description, photoUrl, itemPrice)
                        VALUES (@itemId, @sellerId, @postDate, @title, @description, @photoUrl, @itemPrice);
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
                command.Parameters.AddWithValue("@postDate", DateTime.Now);
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@photoUrl", photoUrl);
                command.Parameters.AddWithValue("@itemPrice", itemPrice);
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
    public DataGridView searchInitalize(DataGridView dgv)
    {
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
        {
            DataTable dt;


            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "buttonColumn";
            buttonColumn.Text = "Save";
            buttonColumn.HeaderText = "Save to Shopping";
            buttonColumn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn buttonColumn2 = new DataGridViewButtonColumn();
            buttonColumn2.Name = "buttonColumn2";
            buttonColumn2.Text = "Buy";
            buttonColumn2.HeaderText = "Purchasing";
            buttonColumn2.UseColumnTextForButtonValue = true;

            dgv.Columns.Add(buttonColumn2);
            dgv.Columns.Add(buttonColumn);
 

            connection.Open();

 
            string query = @"
                            SELECT i.title as 'Title', '$' || i.itemPrice as 'Item Price', u.username as 'Seller Name', i.postDate as 'Post Date', i.itemId as 'Item ID', i.description as 'Description'
                            FROM item i
                            JOIN _user u ON u.userId = i.sellerId
                            WHERE i.buyerId IS NULL;
                        ";

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                dt = new DataTable("Items");
                adapter.Fill(dt);
                dgv.DataSource = dt;
                return dgv;
            }
        }
    }

    public DataGridView sButton(string titleQuery, DataGridView dgv)
    {
        // Check if the button column already exists
        /*
        bool buttonColumnExists = false;
        foreach (DataGridViewColumn column in dgv.Columns)
        {
            if (column.Name == "buttonColumn")
            {
                buttonColumnExists = true;
                break;
            }
        }

        // If the button column doesn't exist, create and add it
        if (!buttonColumnExists)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "buttonColumn";
            buttonColumn.Text = "Save";
            buttonColumn.HeaderText = "Save to Shopping";
            buttonColumn.UseColumnTextForButtonValue = true;

            dgv.Columns.Add(buttonColumn);
        }
        */

        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
        {
            DataTable dt;

            connection.Open();

            string query = @"
                            SELECT i.title as 'Title', '$' || i.itemPrice as 'Item Price', u.username as 'Seller Name', i.postDate as 'Post Date', i.itemId as 'Item ID', i.description as 'Description'
                            FROM item i
                            JOIN _user u ON u.userId = i.sellerId
                            WHERE i.title LIKE @title AND i.buyerId IS NULL;
                        ";
  

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@title", "%" + titleQuery + "%");

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                dt = new DataTable("Items");
                adapter.Fill(dt);
                dgv.DataSource = dt;
                return dgv;
            }
        }
    }

    public bool checkIfItemAlreadySaved(string itemId)
    {
        string query = @"
                    SELECT COUNT(*) 
                    FROM savedItems 
                    WHERE itemId = @itemId AND savedUserId = @savedUserId;
                    ";

        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
        {
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@itemId", itemId);
                command.Parameters.AddWithValue("@savedUserId", Program.GlobalStrings[1]);
                object result = command.ExecuteScalar();
                if (result.ToString() == "0") { return true; }
            }
            return false;
        }
    }


    public List<string> checkForSavedItems()
    {
        List<string> itemList = new List<string>();
        string query = @"
                SELECT itemId, savedUserId, title 
                FROM savedItems
                WHERE savedUserId = @userId;
                ";

        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
        {
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@userId", Program.GlobalStrings[1]);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (!reader.HasRows)
                    {
                        return null;
                    }

                    while (reader.Read())
                    {
                        int? itemId = reader.IsDBNull(0) ? null : (int?)reader.GetInt32(0);
                        int? savedUserId = reader.IsDBNull(1) ? null : (int?)reader.GetInt32(1);
                        string title = reader.IsDBNull(2) ? null : reader.GetString(2);

                        string itemInfo = $"{title}";
                        itemList.Add(itemInfo);
                    }
                }
                return itemList;
            }
        }
    }

    public List<string> checkForBoughtItems()
    {
        List<string> itemList = new List<string>();
        string query = @"
                    SELECT i.itemId, i.sellerId, i.title
                    FROM _user u
                    JOIN item i ON u.userId = i.buyerId
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
                    if (!reader.HasRows)
                    {
                        return null;
                    }

                    while (reader.Read())
                    {
                        int? itemId = reader.IsDBNull(0) ? null : (int?)reader.GetInt32(0);
                        int? sellerId = reader.IsDBNull(1) ? null : (int?)reader.GetInt32(1);
                        string title = reader.IsDBNull(2) ? null : reader.GetString(2);

                        string itemInfo = $"{title}";
                        itemList.Add(itemInfo);
                    }
                }
                return itemList;
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
    




