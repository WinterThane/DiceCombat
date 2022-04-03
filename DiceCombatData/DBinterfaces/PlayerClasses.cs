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
            ClassModel playerClass = new();

            using (var context = new DiceContext())
            {
                if (className != null)
                {
                    playerClass = context.ClassModels.OfType<ClassModel>().FirstOrDefault(x => x.Name == className);
                }
            }

            return playerClass;
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
