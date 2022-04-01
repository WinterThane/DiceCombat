using DiceCombatData.Database;
using DiceCombatData.Models;
using Microsoft.EntityFrameworkCore;

namespace DiceCombatData.DBinterfaces
{
    public class DiceContext : DbContext
    {
        public DbSet<ClassModel> ClassModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Config.ConnString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClassModel>().ToTable("BaseClass");
        }
    }
}
