using DiceCombatData.DBinterfaces;
using DiceCombatData.Models;
using System.Collections.Generic;

namespace DiceCombatGame.ViewModels
{
    public class AddClassViewModel : BaseViewModel
    {
        public List<ClassModel> PlayerClassesList { get; set; }

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
            GetClasses();
        }

        public void GetClasses() => PlayerClassesList = PlayerClasses.GetClassesList();

        public void SaveClass()
        {
            if (ClassModel != null)
            {
                PlayerClasses.WriteNewClass(ClassModel);
            }
        }
    }
}
