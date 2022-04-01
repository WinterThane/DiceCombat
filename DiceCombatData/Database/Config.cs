using System;

namespace DiceCombatData.Database
{
    internal static class Config
    {
        public static string ConnString = "Data Source=" + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\DiceCombat\DiceCombatDB.sqlite;";
    }
}
