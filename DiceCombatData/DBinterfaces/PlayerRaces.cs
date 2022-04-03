using DiceCombatData.Models;
using System.Collections.Generic;
using System.Linq;

namespace DiceCombatData.DBinterfaces
{
    public static class PlayerRaces
    {
        public static List<RaceModel> GetPlayerRaces()
        {
            List<RaceModel> racesList = new();

            using (var context = new DiceContext())
            {
                racesList = context.RaceModels.OfType<RaceModel>().ToList();
            }

            return racesList;
        }

        public static RaceModel GetSpecificRace(string playerRace)
        {
            RaceModel raceModel = new();

            using (var context = new DiceContext())
            {
                if (playerRace != null)
                {
                    raceModel = context.RaceModels.OfType<RaceModel>().FirstOrDefault(x => x.Name == playerRace);
                }
            }

            return raceModel;
        }
    }
}
