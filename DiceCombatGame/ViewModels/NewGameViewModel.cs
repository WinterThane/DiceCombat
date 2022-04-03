using DiceCombatData.DBinterfaces;
using DiceCombatData.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace DiceCombatGame.ViewModels
{
    public class NewGameViewModel : BaseViewModel
    {
        private List<RaceModel> playerRacesList;

        public List<RaceModel> PlayerRacesList
        {
            get { return playerRacesList; }
            set { playerRacesList = value; }
        }

        public NewGameViewModel()
        {
            GetPlayerRaces();
        }

        public void GetPlayerRaces() => PlayerRacesList = PlayerRaces.GetPlayerRaces();

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
