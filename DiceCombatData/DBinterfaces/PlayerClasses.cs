using DiceCombatData.Models;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace DiceCombatData.DBinterfaces
{
    public static class PlayerClasses
    {
        public static List<ClassModel> GetClassesList()
        {
            List<ClassModel> classesList = new();

            using (var context = new DiceContext())
            {
                classesList = context.ClassModels.OfType<ClassModel>().ToList();
            }

            return classesList;
        }

        public static ClassModel GetSpecificClass(string className)
        {
            ClassModel classesList = new();

            //using (var connection = new SqliteConnection(Config.ConnString))
            //{
            //    connection.Open();
            //    SqliteCommand command = connection.CreateCommand();
            //    command.CommandText = @"SELECT * FROM BaseClass WHERE Name = $className";
            //    command.Parameters.AddWithValue("$className", className);

            //    using SqliteDataReader? reader = command.ExecuteReader();
            //    while (reader.Read())
            //    {
            //        classesList.Name = reader.GetString(1);
            //        classesList.Strength = reader.GetInt32(2);
            //        classesList.Intelligence = reader.GetInt32(3);
            //        classesList.Dexterity = reader.GetInt32(4);
            //    }
            //}

            return classesList;
        }

        public static void WriteNewClass(ClassModel classModel)
        {
            using (var context = new DiceContext())
            {
                var newClass = new ClassModel()
                {
                    Name = classModel.Name,
                    Strength = classModel.Strength,
                    Intelligence = classModel.Intelligence,
                    Dexterity = classModel.Dexterity
                };

                try
                {
                    context.ClassModels.Add(newClass);
                    context.SaveChanges();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
