using DiceCombatData.Database;
using DiceCombatData.Models;
using Microsoft.Data.Sqlite;
using System.Collections.Generic;

namespace DiceCombatData.DBinterfaces
{
    public static class PlayerClasses
    {
        public static List<ClassModel> GetClassesList()
        {
            List<ClassModel> classesList = new();

            using (var connection = new SqliteConnection(Config.ConnString))
            {
                connection.Open();
                SqliteCommand command = connection.CreateCommand();
                command.CommandText = @"SELECT * FROM TestBaseClass";

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

        public static ClassModel GetSpecificClass(string className)
        {
            ClassModel classesList = new();

            using (var connection = new SqliteConnection(Config.ConnString))
            {
                connection.Open();
                SqliteCommand command = connection.CreateCommand();
                command.CommandText = @"SELECT * FROM TestBaseClass WHERE Name = $className";
                command.Parameters.AddWithValue("$className", className);

                using SqliteDataReader? reader = command.ExecuteReader();
                while (reader.Read())
                {
                    classesList.Name = reader.GetString(1);
                    classesList.Strength = reader.GetInt32(2);
                    classesList.Intelligence = reader.GetInt32(3);
                    classesList.Dexterity = reader.GetInt32(4);
                }
            }

            return classesList;
        }
    }
}
