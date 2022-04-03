using System;
using System.Collections.Generic;
using System.IO;

namespace DiceCombatGame.ViewModels
{
    public class NewGameViewModel : BaseViewModel
    {
        public static List<string> GetPortraitList()
        {
            List<string> paths = new ();
            DirectoryInfo dirInfo = new(AppDomain.CurrentDomain.BaseDirectory + @"\Images\Portraits\Player");

            foreach (FileInfo file in dirInfo.GetFiles())
            {
                paths.Add(file.FullName);
            }

            return paths;
        }
    }
}
