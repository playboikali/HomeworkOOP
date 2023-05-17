namespace Football
{
    class Program
    {
        public static void Main(string[] args)
        {
            Coach coachTeam1 = new Coach("Gosho", 45);
            FootballPlayer[] players1 = new FootballPlayer[11];
            for (int i = 0; i < players1.Length; i++)
            {
                players1[i] = new FootballPlayer("Dakata", 24, 10, 1.80);
            }
            Team team1 = new Team(coachTeam1, players1, "Rechica");

            Coach coachTeam2 = new Coach("Pesho", 60);
            FootballPlayer[] players2 = new FootballPlayer[11];
            for (int i = 0; i < players2.Length; i++)
            {
                players2[i] = new FootballPlayer("Pencho", 32, 7, 1.90);
            }
            Team team2 = new Team(coachTeam2, players2, "Mechkarevo");

            Game.Goals(team1, team2);
        }
    }
}
