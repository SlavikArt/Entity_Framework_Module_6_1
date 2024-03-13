using FootballLeague.Entities;
using Microsoft.EntityFrameworkCore;

namespace FootballLeague
{
    public class FootballLeagueContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }

        //public FootballLeagueContext()
        //{
        //    Database.EnsureDeleted();
        //    Database.EnsureCreated();
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-MCLUN3BN\SQLSERVER;Database=FootballLeagueDb;Trusted_Connection=True;Encrypt=False;");
        }
    }
}
