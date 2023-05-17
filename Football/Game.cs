using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public Referee AssistentReferee1 { get; set; }
        public Referee AssistentReferee2 { get; set; }

        public Game(Coach coach, FootballPlayer[] players, Team team1, Team team2, Referee referee, Referee assistent1, Referee assistent2)
        {
            Team1 = team1;
            Team2 = team2;
            Referee = referee;
            AssistentReferee1 = assistent1;
            AssistentReferee2 = assistent2;
        }

        public static void Goals(Team team1, Team team2)
        {
            int team1Goals = 0;
            int team2Goals = 0;

            for (int i = 0; i <= 90; i++)
            {
                int random = Random.Shared.Next(100);
                if (random < 5)
                {
                    Random randomPlayer = new Random();
                    int player = randomPlayer.Next(0, team1.footballPlayers.Length);
                    Console.WriteLine($"{team1.footballPlayers[player].Name} scored in {i} minute!");
                    team1Goals++;
                }
                else if (random > 95)
                {
                    Random randomPlayer = new Random();
                    int player = randomPlayer.Next(0, team2.footballPlayers.Length);
                    Console.WriteLine($"{team2.footballPlayers[player].Name} scored in {i} minute!");
                    team2Goals++;
                }
            }
            Console.WriteLine();
            Result(team1Goals, team2Goals, team1, team2);

            Console.WriteLine();
            Winner(team1Goals, team2Goals, team1, team2);
        }

        private static void Result(int goals1, int goals2, Team team1, Team team2)
        {
            Console.WriteLine("The result is: ");
            Console.WriteLine($"{team1.TeamName} goals: {goals1}.");
            Console.WriteLine($"{team2.TeamName} goals: {goals2}.");
        }
        private static void Winner(int goals1, int goals2, Team team1, Team team2)
        {
            if (goals1 == goals2)
            {
                Console.WriteLine("Draw!");
            }
            else if (goals1 > goals2)
            {
                Console.WriteLine($"The winner is {team1.TeamName}!");
            }
            else
            {
                Console.WriteLine($"The winner is {team2.TeamName}!");
            }
        }
    }
}
