using System.Diagnostics.CodeAnalysis;

namespace DiceCombatData.Models
{
    public class ClassModel
    {
        [AllowNull]
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Dexterity { get; set; }
    }
}
