using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Data.SQLite;
using System.Reflection;
using System.Runtime.InteropServices.JavaScript;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data;
using System.Data.Common;
using BudgetGui.Screens;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

public partial class sqlDriver
{
    public void SendMessage(string sender, DateTime timeDate, string recipient, string text1)
    {

        string query = @"INSERT INTO _message (sender, timeDate, recipient, text1) VALUES (@sender, @timeDate, @recipient, @text1)";
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
        {
            connection.Open();

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@sender", sender);
                command.Parameters.AddWithValue("@timeDate", timeDate);
                command.Parameters.AddWithValue("@recipient", recipient);
                command.Parameters.AddWithValue("@text1", text1);
                command.ExecuteNonQuery();
            }
        }
    }

    /// <summary>
    /// this will get the messages between two people, if any
    /// </summary>
    /// <param name="selfID"></param>
    /// <param name="otherID"></param>
    /// <returns></returns>
    public List<message_card> getMessages(string selfID, string otherID)
    {
        string query = @"SELECT * FROM _message WHERE (sender = @selfID AND recipient = @otherID) OR (sender = @otherID AND recipient = @selfID) ORDER BY timeDate";
        string query_photo_user = @"SELECT profile_pic FROM _user WHERE userId = @selfID LIMIT 1";
        string query_photo_other = @"SELECT profile_pic FROM _user WHERE userId = @otherID LIMIT 1";

        string _user_pic = "";
        string _other_pic = "";


        List<message_card> message_Cards = new List<message_card>();

        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
        {
            connection.Open();

            using (SQLiteCommand command = new SQLiteCommand(query_photo_user, connection))
            {
                command.Parameters.AddWithValue("@selfID", selfID);

                using (var xx = command.ExecuteReader())
                {
                    foreach (DbDataRecord s in xx)
                    {
                        if (s["profile_pic"] != null)
                        {
                            _user_pic = s["profile_pic"].ToString();
                        }
                        else
                        {
                            _user_pic = "blank-profile-picture.png";
                        }
                        MessageBox.Show(_user_pic);
                    }
                }
            }

            connection.Close();
        }
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
        {
            connection.Open();

            using (SQLiteCommand command = new SQLiteCommand(query_photo_other, connection))
            {
                command.Parameters.AddWithValue("@otherID", otherID);

                using (var xx = command.ExecuteReader())
                {
                    
                    foreach (DbDataRecord s in xx)
                    {
                        
                        if (s["profile_pic"] != null)
                        {
                            _other_pic = s["profile_pic"].ToString();
                        }
                        else
                        {
                            _other_pic = "blank-profile-picture.png";
                        }
                        MessageBox.Show(_other_pic);
                    }
                }
            }



            connection.Close();
        }
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
        {
            connection.Open();

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@selfID", selfID);
                command.Parameters.AddWithValue("@otherID", otherID);
                int[] ints = { 0 };

                using (var xx = command.ExecuteReader())
                {
                    
                    foreach (DbDataRecord s in xx)
                    {
                        string sender = s["sender"].ToString();
                        string text = s["text1"].ToString();

                        if(selfID == sender)
                        {
                            ints[0] = 0;
                        }
                        else
                        {
                            ints[0] = 1;
                        }

                        string[] strings = { text, _user_pic, _other_pic };
                        message_card m = new message_card(strings, ints);
                        message_Cards.Add(m);
                    }
                }
                return message_Cards;
            }
        }
    }


    public DataTable getConversations(string selfID)
    {
        string query = @"SELECT DISTINCT recipient FROM _message WHERE sender = @selfID";

        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
        {
            connection.Open();
            DataTable dataTable = new DataTable();
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                try
                {
                    command.Parameters.AddWithValue("@selfID", selfID);
                    SQLiteDataReader reader = command.ExecuteReader();
                    dataTable.Load(reader);
                }
                catch (Exception e)
                {
                }
                
            }
            return dataTable;
        }
    }
}