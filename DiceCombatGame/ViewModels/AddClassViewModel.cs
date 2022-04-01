using DiceCombatData.DBinterfaces;
using DiceCombatData.Models;
using System.Windows;

namespace DiceCombatGame.ViewModels
{
    public class AddClassViewModel : BaseViewModel
    {
        private ClassModel classModel;
        public ClassModel ClassModel
        {
            get { return classModel; }
            set
            {
                classModel = value;
                OnPropertyChange(nameof(ClassModel));
            }
        }

        public AddClassViewModel()
        {
            ClassModel = new ClassModel();
        }

        public void SaveClass()
        {
            if (ClassModel != null)
            {
                PlayerClasses.WriteNewClass(ClassModel);
            }
        }
    }
}
