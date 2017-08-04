using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsCounter
{
    class Player
    {
        public string Name { get; set; }
        public int Points { get; set; }

        public Player(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }
    }

    class PointsCounter
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, List<Player>>();
            string input = Console.ReadLine();

            while (input != "Result")
            {
                string[] tokens = input
                    .Split('|');
                string teamName;
                string playerName;
                int points = int.Parse(tokens[2]);

                if (IsTeamName(tokens[0]))
                {
                    teamName = tokens[0];
                    playerName = tokens[1];
                }
                else
                {
                    teamName = tokens[1];
                    playerName = tokens[0];
                }
                teamName = Unpolluted(teamName);
                playerName = Unpolluted(playerName);
                if (!data.ContainsKey(teamName))
                {
                    data.Add(teamName, new List<Player>());
                }
                Console.WriteLine($"{teamName} => {}");
                input = Console.ReadLine();
            }
        }

        static string Unpolluted(string name)
        {
            StringBuilder result = new StringBuilder();
            foreach (var symbol in name)
            {
                if (IsPollutedChar(symbol))
                {
                    result.Append(symbol);
                }
            }
            return result.ToString();
        }

        static bool IsPollutedChar(char symbol)
        {
            return symbol == '@' ||
                symbol == '%' ||
                symbol == '$' ||
                symbol == '*';
        }
        static bool IsTeamName(string name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                if (char.IsLower(name[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
