using Microsoft.Data.Sqlite;
using System.Collections.Generic;

namespace DiceCombatData.Test
{
    public static class TestDB
    {
        public static List<string> GetData()
        {
            List<string> namesList = new();

            using (var connection = new SqliteConnection("Data Source=Database\\DiceCombatGameDB.db"))
            {
                connection.Open();
                SqliteCommand command = connection.CreateCommand();
                command.CommandText = @"SELECT Name FROM TestBaseClass";
                //command.CommandText = @" SELECT name FROM user WHERE id = $id";
                //command.Parameters.AddWithValue("$id", id);

                using SqliteDataReader? reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var name = reader.GetString(0);
                    namesList.Add(name);
                }
            }

            return namesList;
        }
    }
}
