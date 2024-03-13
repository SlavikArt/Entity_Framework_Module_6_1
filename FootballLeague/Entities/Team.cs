using System.ComponentModel.DataAnnotations;


namespace FootballLeague.Entities
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }

        [MaxLength(100)]
        public string? Name { get; set; }

        [MaxLength(100)]
        public string? City { get; set; }

        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }
        public int GoalsScored { get; set; }
        public int GoalsMissed { get; set; }

        static public void Print(ICollection<Team> teams)
        {
            foreach (var team in teams)
            {
                Console.WriteLine(team + "\n");
            }
        }
        static public void Print(Team team)
        {
            Console.WriteLine(team + "\n");
        }

        public override string ToString()
        {
            return $"Name: {Name}, City: {City}\n" +
                $"Wins: {Wins}, Losses: {Losses}, Draws: {Draws}\n" +
                $"Goals Scored: {GoalsScored}, Goals Missed: {GoalsMissed}";
        }
    }
}
