using DiceCombatData.Models;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;

namespace DiceCombatData.Write
{
    public static class AddClassToDB
    {
        public static List<ClassModel> ClassesList()
        {
            List<ClassModel> classesList = new();

            using (var connection = new SqliteConnection("Data Source=Database\\DiceCombatGameDB.db"))
            {
                connection.Open();
                SqliteCommand command = connection.CreateCommand();
                command.CommandText = @"SELECT * FROM TestBaseClass";
                //command.CommandText = @" SELECT name FROM user WHERE id = $id";
                //command.Parameters.AddWithValue("$id", id);

                using SqliteDataReader? reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var playerClass = new ClassModel
                    {
                        Name = reader.GetString(1),
                        Strength = reader.GetInt32(2),
                        Intelligence = reader.GetInt32(3),
                        Dexterity = reader.GetInt32(4)
                    };
                    classesList.Add(playerClass); 
                }
            }

            return classesList;
        }
    }
}
