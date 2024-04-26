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
using System.Data.SqlTypes;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.Common;

public partial class sqlDriver
{

    ////////////////////////////////////////////////////////
    /////////////////// delete queries ////////////////////
    ////////////////////////////////////////////////////////
    public void delete_item_by_id(int item_id)
    {
        string delete_query = "DELETE FROM item WHERE itemId = @item_id;";
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
        {
            connection.Open();

            using (SQLiteCommand command = new SQLiteCommand(delete_query, connection))
            {

                command.Parameters.AddWithValue("@item_id", item_id);
                command.ExecuteNonQuery();
            }
        }
    }

    ////////////////////////////////////////////////////////
    //////////////////// update queries ////////////////////
    ////////////////////////////////////////////////////////

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

                try
                {

                    command.ExecuteNonQuery();

                }
                catch (SQLiteException ex)
                {
                    if (ex.Message.Contains("CHECK constraint failed:"))
                    {

                        MessageBox.Show("Error: Please double check your inputs.");
                    }
                }
                return;
            }
        }
    }

    ////////////////////////////////////////////////////////
    //////////////////// insert queries ////////////////////
    ////////////////////////////////////////////////////////

    public void save_item(int item_id)
    {
        // Create SQL command
        string insertSavedItemQuery = $@"
                                INSERT INTO savedItems (itemId, title, description, creatorUserId, savedUserId, postDate, itemPrice) 
                                SELECT itemId, title, description, sellerId, @userid, postDate, itemPrice 
                                FROM item 
                                WHERE itemId = @itemId;";

        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
        {
            connection.Open();

            using (SQLiteCommand command = new SQLiteCommand(insertSavedItemQuery, connection))
            {

                command.Parameters.AddWithValue("@userid", Program.GlobalStrings[1]);
                command.Parameters.AddWithValue("@itemId", item_id);

                 try
                {

                    command.ExecuteNonQuery();

                }
                catch (SQLiteException ex)
                {
                }
                return;
            }
        }
    }

    public void remove_saved_item(int itemId, int userid)
    {

        string delete_saved = @"DELETE FROM savedItems WHERE itemId = @itemId and savedUserId = @userid";
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
        {
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(delete_saved, connection))
            {
                command.Parameters.AddWithValue("@itemId", itemId);
                command.Parameters.AddWithValue("@userid", userid);
                command.ExecuteNonQuery();
            }
        }
    }

    public void createNewItem(string title, string description, string photoUrl, string itemPrice)
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

                try
                {

                    command.ExecuteNonQuery();
                    MessageBox.Show("Item Created Successfully");

                }
                catch (SQLiteException ex)
                {
                    if (ex.Message.Contains("CHECK constraint failed:"))
                    {
                        MessageBox.Show("Error: Please double check your inputs.");
                        return;
                    }
                    else
                    {
                        throw;
                    }
                }            

               
            }
        }
    }

    public void updateItem(int itemId, string title, string description, string photoUrl, string itemPrice)
    {
        string query = @"
                        UPDATE item SET 
                        title = @title,
                        description = @description, 
                        photoUrl = @photoUrl,
                        itemPrice = @itemPrice
                        WHERE itemID = @itemId ;";
        int newItemId = 1;
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
        {
            connection.Open();
            
            
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@title", title);
                command.Parameters.AddWithValue("@description", description);
                command.Parameters.AddWithValue("@photoUrl", photoUrl);
                command.Parameters.AddWithValue("@itemPrice", itemPrice);
                command.Parameters.AddWithValue("@itemId", itemId);

                try
                {

                    command.ExecuteNonQuery();

                }
                catch (SQLiteException ex)
                {

                }
                return;

            }
        }
    }
    ////////////////////////////////////////////////////////
    /////////////////// multiple queries ///////////////////
    ////////////////////////////////////////////////////////

    public void updated_bought_item(int itemId)
    {

        //MessageBox.Show(itemId.ToString());
        string delete_saved = @"DELETE FROM savedItems WHERE itemId = @itemId";
        string updateBoughtItemQuery = @"UPDATE item SET buyerId = @buyerId, purchaseDate = @dateTime WHERE itemId = @itemId";

        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
        {
            connection.Open();

            using (SQLiteTransaction transaction = connection.BeginTransaction())
            using (SQLiteCommand command_d = new SQLiteCommand(delete_saved, connection))
            using (SQLiteCommand command_u = new SQLiteCommand(updateBoughtItemQuery, connection))
            {
                command_u.Parameters.AddWithValue("@itemId", itemId);
                command_d.Parameters.AddWithValue("@itemId", itemId);

                command_u.Parameters.AddWithValue("@buyerId", Program.GlobalStrings[1]);
                command_u.Parameters.AddWithValue("@dateTime", DateTime.Today.ToString("yyyy-MM-dd hh:mm:ss"));

                try
                {
                    command_d.ExecuteNonQuery();
                    command_u.ExecuteNonQuery();
                    transaction.Commit();

                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("");
                    MessageBox.Show(ex.Message);
                    transaction.Rollback();
                }
                finally
                {
                    command_d.Dispose();
                    command_u.Dispose();
                    transaction.Dispose();
                }
            }
            return;
        }
    }


    ////////////////////////////////////////////////////////
    ///////////////////// get queries //////////////////////
    ////////////////////////////////////////////////////////

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

    public DataTable checkForSavedItems()
    {
        DataTable itemList = new DataTable();
        string query = @"
                SELECT *
                FROM savedItems s
                JOIN item i ON i.itemId = s.itemId
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
                    try
                    {
                        itemList.Load(reader);

                    }
                    catch (Exception)
                    {

                    }

                }
                return itemList;
            }
        }
    }

    public DataTable checkForBoughtItems()
    {
        DataTable itemList = new DataTable();
        string query = @"
                    SELECT *
                    FROM item i
                    JOIN _user u ON u.userId = i.buyerId
                    WHERE u.userId = @userId;
                    "; //
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
        {
            connection.Open();
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@userId", Program.GlobalStrings[1]);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {

                    try
                    {
                        itemList.Load(reader);

                    }
                    catch (Exception)
                    {

                    }
                    
                }
                return itemList;
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
                obj = JObject.Parse(json.Remove(json.Length - 1).Remove(0, 1));
            }
            return obj;
        }
    }

    public DataTable checkForItemsBeingSold()
    {
        DataTable itemList = new DataTable();
        string query = @"
                    SELECT i.*, u.*
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
                    if (reader.Read())
                    {
                        itemList.Load(reader);
                    }

                }
                return itemList;
            }
        }
    }

    public DataTable checkForItemsSold()
    {
        DataTable dataTable = new DataTable();
        string query = @"
                    SELECT i.*, u.*
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
                    
                    try
                    {
                        dataTable.Load(reader);

                    }
                    catch (Exception)
                    {

                    }
                }
                return dataTable;
            }
        }
    }

    public DataGridView searchInitalize(DataGridView dgv)
    {

        DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
        buttonColumn.Name = "buttonColumn";
        buttonColumn.Text = "Save";
        buttonColumn.HeaderText = "Save to Shopping";
        buttonColumn.UseColumnTextForButtonValue = true;

        DataGridViewButtonColumn buttonColumn2 = new DataGridViewButtonColumn();
        buttonColumn2.Name = "buttonColumn2";
        buttonColumn2.Text = "Buy";
        buttonColumn2.HeaderText = "Purchase";
        buttonColumn2.UseColumnTextForButtonValue = true;

        DataGridViewButtonColumn buttonColumn3 = new DataGridViewButtonColumn();
        buttonColumn3.Name = "buttonColumn3";
        buttonColumn3.Text = "Message";
        buttonColumn3.HeaderText = "Send a Message";
        buttonColumn3.UseColumnTextForButtonValue = true;

        dgv.Columns.Add(buttonColumn2);
        dgv.Columns.Add(buttonColumn);
        dgv.Columns.Add(buttonColumn3);

        return dgv;

    }

    public DataGridView sButton(string titleQuery, DataGridView dgv)
    {

        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
        {
            DataTable dt;

            connection.Open();


            string query = @"
                        SELECT title as 'Title', '$' || itemPrice as 'Item Price', username as 'Seller Name', postDate as 'Post Date', itemId as 'Item ID', description as 'Description'
                        FROM itemSearch
                        WHERE Title LIKE @title;
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

}





