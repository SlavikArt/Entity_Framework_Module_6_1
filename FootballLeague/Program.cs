using FootballLeague.Entities;

namespace FootballLeague
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Data Insert
            using (var db = new FootballLeagueContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                var TeamAtleticoMadrid = new Team
                {
                    Name = "Atlético Madrid",
                    City = "Madrid",
                    Wins = 10,
                    Losses = 2,
                    Draws = 3,
                    GoalsScored = 2,
                    GoalsMissed = 1
                };
                var TeamValencia = new Team 
                { 
                    Name = "Valencia",
                    City = "Valencia",
                    Wins = 8, 
                    Losses = 4,
                    Draws = 3,
                    GoalsScored = 3,
                    GoalsMissed = 0
                };
                
                db.Teams.AddRange(TeamAtleticoMadrid, TeamValencia);
                db.SaveChanges();
            }
            
            // Data Output
            using (var db = new FootballLeagueContext())
            {
                Team.Print(db.Teams.ToList());
            }
        }
    }
}