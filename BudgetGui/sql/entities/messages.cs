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

public partial class sqlDriver
{
    public void SendMessage(int sender, DateTime timeDate, int recipient, string text1)
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
    public List<message_card> getMessages(int selfID, int otherID)
    {
        string query = @"SELECT * FROM _messages WHERE (sender = @selfID AND recipient = @otherID) OR (sender = @otherID AND recipient = @selfID) ORDER BY timeDate";

        List<message_card> message_Cards = new List<message_card>();

        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
        {
            connection.Open();

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@selfID", selfID);
                command.Parameters.AddWithValue("@otherID", otherID);
                System.Data.SQLite.SQLiteDataReader reader = command.ExecuteReader();
                int[] ints = { 0 };

                using (var xx = command.ExecuteReader())
                {
                    foreach (DbDataRecord s in xx)
                    {
                        int sender = (Int32)s["sender"];
                        string text = s["text1"].ToString();


                        if(selfID == sender)
                        {
                            ints[0] = 0;
                        }
                        else
                        {
                            ints[0] = 1;
                        }

                        string pic_location = getUsersById(sender)["profilePicture"].ToString();

                        string[] strings = { text, pic_location };
                        message_card m = new message_card(strings, ints);
                        message_Cards.Add(m);
                    }
                }
                return message_Cards;
            }
        }
    }


    public JObject getConversations(int selfID)
    {
        string query = @"SELECT DISTINCT recipient FROM _messages WHERE sender = @selfID";

        JObject obj;
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
        {
            connection.Open();

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@selfID", selfID);
                System.Data.SQLite.SQLiteDataReader reader = command.ExecuteReader();
                var r = Serialize(reader);
                obj = JObject.Parse(JsonConvert.SerializeObject(r));
            }
            return obj;
        }
    }
}