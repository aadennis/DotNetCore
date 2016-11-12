using System;
using Microsoft.Data.Sqlite;

public class Example
{

    static void Main()
    {
        string cs = "Data Source=:memory:";

        using (SqliteConnection con = new SqliteConnection(cs))
        {
            con.Open();
            var commandText = "SELECT SQLITE_VERSION()";
            using (SqliteCommand cmd = new SqliteCommand(commandText, con))
            {
                
                var version = Convert.ToString(cmd.ExecuteScalar());
                Console.WriteLine("SQLite versionx : {0}", version);
            }
            con.Close();
        }
    }
}