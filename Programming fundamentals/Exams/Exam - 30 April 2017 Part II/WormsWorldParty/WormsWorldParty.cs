using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WormsWorldParty
{
    class WormsWorldParty
    {
        static void Main(string[] args)
        {
            var dataBase = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            var wormCatch = new List<string>();

            while (input != "quit")
            {
                var inputParams = input
                    .Split(new[] { " -> " },
                        StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var name = inputParams[0];
                var team = inputParams[1];
                var score = int.Parse(inputParams[2]);
                if (wormCatch.Contains(name))
                {
                    continue;
                }

                if (!dataBase.ContainsKey(team))
                {
                    dataBase[team] = new Dictionary<string, int>();
                    
                }
                if (!dataBase.ContainsKey(name))
                {
                    dataBase[name] = new Dictionary<string, int>();
                }
                dataBase[team][name] = score;
                wormCatch.Add(name);
                input = Console.ReadLine();
            }

            var counter = 1;

            foreach (var teamResult in dataBase)           
            {
                var scoreSum = teamResult.Value.Values.Sum();
                Console.WriteLine($"{counter}. Team: {teamResult.Key} - {scoreSum}");
                counter++;

                foreach (var worms in teamResult.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"###{worms.Key} : {worms.Value}");
                }
            }

        }
    }
}
