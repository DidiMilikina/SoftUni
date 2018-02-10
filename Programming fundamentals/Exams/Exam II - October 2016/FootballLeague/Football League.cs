using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            var standings = new Dictionary<string, int>();
            var teamGoals = new Dictionary<string, int>();

            string key = Console.ReadLine();
            string line;

            while ((line = Console.ReadLine()) != "final")
            {
                string[] tokens = line
                    .Split();

                string firstTeamName = GetTeamName(tokens[0], key);
                string secondTeamName = GetTeamName(tokens[1], key);

                string[] score = tokens[2]
                    .Split(':');
                int firstTeamGoals = int.Parse(score[0]);
                int secondTeamGoals = int.Parse(score[1]);

                if (firstTeamGoals > secondTeamGoals)
                {
                    AddScoreToTeam(standings, firstTeamName, 3);
                    AddScoreToTeam(standings, secondTeamName, 0);
                }
                else if (firstTeamGoals < secondTeamGoals)
                {
                    AddScoreToTeam(standings, firstTeamName, 0);
                    AddScoreToTeam(standings, secondTeamName, 3);
                }
                else
                {
                    AddScoreToTeam(standings, firstTeamName, 1);
                    AddScoreToTeam(standings, secondTeamName, 1);
                }



                AddScoreToTeam(teamGoals, firstTeamName, firstTeamGoals);
                AddScoreToTeam(teamGoals, secondTeamName, secondTeamGoals);
            }

            Console.WriteLine("League standings:");
            var sortedStandings = standings
                .OrderByDescending(t => t.Value)
                .ThenBy(t => t.Key);
            int countTeamsGoals = 1;

            foreach (var teamKVP in sortedStandings)
            {
                var teamNamePrint = teamKVP.Key;
                var teamPointsPrint = teamKVP.Value;

                Console.WriteLine($"{countTeamsGoals}. {teamNamePrint} {teamPointsPrint}");
                countTeamsGoals++;
            }

            Console.WriteLine("Top 3 scored goals:");
            var topGoalsSorted = teamGoals
                .OrderByDescending(t => t.Value)
                .ThenBy(t => t.Key)
                .Take(3);
            foreach (var goals in topGoalsSorted)
            {
                var teamName = goals.Key;
                var scoredGoals = goals.Value;
                Console.WriteLine($"- {teamName} -> {scoredGoals}");
                countTeamsGoals++;
            }
        }

        private static void AddScoreToTeam(Dictionary<string, int> standings, string firstTeamName, int firstTeamScore)
        {
            if (!standings.ContainsKey(firstTeamName))
            {
                standings.Add(firstTeamName, 0);
            }
            standings[firstTeamName] += firstTeamScore;
        }

        private static string GetTeamName(string teamName, string key)
        {
            int firstIndex = teamName.IndexOf(key) + key.Length;
            int secondIndex = teamName.LastIndexOf(key);
            int length = secondIndex - firstIndex;
            string name = teamName.Substring(firstIndex, length);
            return string.Join("", name.ToUpper().Reverse());
        }
    }
}
