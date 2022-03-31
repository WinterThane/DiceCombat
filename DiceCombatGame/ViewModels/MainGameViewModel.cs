using System.Collections.Generic;
using DiceCombatData.Models;

namespace DiceCombatGame.ViewModels
{
    public class MainGameViewModel : BaseViewModel
    {
        public List<ClassModel> PlayerClassesList { get; set; }

        public MainGameViewModel()
        {
            GetClasses();
        }

        public void GetClasses() => PlayerClassesList = DiceCombatData.DBinterfaces.PlayerClasses.GetClassesList();
    }
}
