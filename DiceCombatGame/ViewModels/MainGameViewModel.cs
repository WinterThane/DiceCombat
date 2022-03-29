using System.Collections.Generic;
using DiceCombatData.Test;

namespace DiceCombatGame.ViewModels
{
    public class MainGameViewModel : BaseViewModel
    {
        public List<string> PlayerClasses { get; set; }

        public MainGameViewModel()
        {
            GetClasses();
        }

        public void GetClasses()
        {
            PlayerClasses = TestDB.GetData();
        }
    }
}
