using System.Diagnostics.CodeAnalysis;

namespace Football
{
    class Team
    {
        public Coach Coach { get; set; }
        public FootballPlayer[] footballPlayers { get; set; } = new FootballPlayer[11];
        public string TeamName { get; set; }

        public Team(Coach coach, FootballPlayer[] players, string name)
        {
            Coach = coach;
            footballPlayers = players;
            TeamName = name;
        }

        public int AverageAge(FootballPlayer[] players)
        {
            int sum = 0;
            for (int i = 0; i < footballPlayers.Length; i++)
            {
                sum = sum + footballPlayers[i].Age;
            }
            return sum / footballPlayers.Length;
        }
    }
}
