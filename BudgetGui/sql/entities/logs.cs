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
    public void InsertLog(
        int logId,
        int userId,
        DateTime timeDate,
        string type,
        JSObject dataJson
        )
    {
        string query = @"INSERT INTO item (logId, userId, timeDate, type, dataJson) VALUES (@logId, @userId, @timeDate, @type, @dataJson)";

        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
        {
            connection.Open();

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@logId", logId);
                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("@timeDate", timeDate);
                command.Parameters.AddWithValue("@type", type);
                command.Parameters.AddWithValue("@dataJson", dataJson);
                command.ExecuteNonQuery();
            }
        }
    }


    /// <summary>
    /// this will get the logs for a user of a particular type
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public JObject getLogsForUserOfType(int userId, int type)
    {
        string query = @"SELECT * FROM logs WHERE userId = @userId AND type = @type ORDER BY timeDate";

        JObject obj;
        using (SQLiteConnection connection = new SQLiteConnection($"Data Source={databaseFilePath};Version=3;"))
        {
            connection.Open();

            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("@type", type);
                System.Data.SQLite.SQLiteDataReader reader = command.ExecuteReader();
                var r = Serialize(reader);
                obj = JObject.Parse(JsonConvert.SerializeObject(r));
            }
            return obj;
        }
    }
}