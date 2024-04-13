using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Reflection;
using System.Runtime.InteropServices.JavaScript;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

public partial class sqlDriver
{
    //Dr. Hendrix wants this cited
    //this code was taken directly from here
    // https://stackoverflow.com/questions/5083709/convert-from-sqldatareader-to-json
    public IEnumerable<Dictionary<string, object>> Serialize(System.Data.SQLite.SQLiteDataReader reader)
    {
        var results = new List<Dictionary<string, object>>();
        var cols = new List<string>();
        for (var i = 0; i < reader.FieldCount; i++)
            cols.Add(reader.GetName(i));

        while (reader.Read())
            results.Add(SerializeRow(cols, reader));

        return results;
    }
    private Dictionary<string, object> SerializeRow(IEnumerable<string> cols,
                                                    System.Data.SQLite.SQLiteDataReader reader)
    {
        var result = new Dictionary<string, object>();
        foreach (var col in cols)
            result.Add(col, reader[col]);
        return result;
    }

    public JObject dictionary_to_json(IEnumerable<Dictionary<string, object>> dictionary)
    {
        JObject result = JObject.Parse( JsonConvert.SerializeObject(dictionary)); 

        return result;
    }

}