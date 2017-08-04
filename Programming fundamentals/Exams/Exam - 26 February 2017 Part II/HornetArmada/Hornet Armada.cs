using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetArmada
{
    class Program
    {
        static void Main(string[] args)
        { 
            var legionAndActivity = new Dictionary<string, int>();
            var legionsData = new Dictionary<string, Dictionary<string, int>>();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                var tokens = Console.ReadLine()
                    .Split(new[] { '=', '-', '>', ':', ' ' },
                        StringSplitOptions.RemoveEmptyEntries);

                var lastActivity = int.Parse(tokens[0]);
                var legionName = tokens[1];
                var soldierType = tokens[2];
                var soldierCount = int.Parse(tokens[3]);

                if (!legionAndActivity.ContainsKey(legionName) && !legionsData.ContainsKey(legionName))
                {
                    legionAndActivity.Add(legionName, lastActivity);
                    legionsData.Add(legionName, new Dictionary<string, int>());
                }
                if (!legionsData[legionName].ContainsKey(soldierType))
                {
                    legionsData[legionName].Add(soldierType, 0);
                }

                legionsData[legionName][soldierType] += soldierCount;

                if (legionAndActivity.ContainsKey(legionName))
                {
                    long currentActivity = legionAndActivity[legionName];

                    if (currentActivity < lastActivity)
                    {
                        legionAndActivity[legionName] = lastActivity;
                    }
                }
            }
        }
    }
}
