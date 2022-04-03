using System.Diagnostics.CodeAnalysis;

namespace DiceCombatData.Models
{
    public class RaceModel
    {
        public int ID { get; set; }
        [AllowNull]
        public string Name { get; set; }
        public double HealthCoef { get; set; }
        public double ManaCoef { get; set; }
        public double ExperienceCoef { get; set; }
        public double ToHit { get; set; }
        public double ToCrit { get; set; }
        public int FireResistance { get; set; }
        public int WaterResistance { get; set; }
        public int AirResistance { get; set; }
        public int EarthResistance { get; set; }
        [AllowNull]
        public string Description { get; set; }
    }
}
