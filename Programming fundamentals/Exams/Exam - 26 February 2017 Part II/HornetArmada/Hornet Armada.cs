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
            var legionAndActivity = new Dictionary<string, long>();
            var legionsData = new Dictionary<string, Dictionary<string, long>>();
            long number = long.Parse(Console.ReadLine());

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
                    legionsData.Add(legionName, new Dictionary<string, long>());
                }

                if (!legionsData[legionName].ContainsKey(soldierType))
                {
                    legionsData[legionName].Add(soldierType, 0);
                }

                legionsData[legionName][soldierType] += soldierCount;

                if (lastActivity > legionAndActivity[legionName])
                {
                    legionAndActivity[legionName] = lastActivity;
                }
            }

            string inputLine = Console.ReadLine();

            if (inputLine.Contains("\\"))
            {
                var inputData = inputLine.Split('\\');
                var givenActivity = long.Parse(inputData[0]);
                var givenSoldierType = inputData[1];

                #region short
                //var sorted = legionsData.Where(pair => pair.Value.ContainsKey(givenSoldierType));
                //sortedLegionData = sortedLegionData.OrderByDescending(pair => pair.Value
                //    .Where(valuePair => valuePair.Key == givenSoldierType).Sum(valuePair => valuePair.Value));
                #endregion

                #region exteded

                var notSorted = new Dictionary<string, long>();
                foreach (var legionSoldierData in legionsData)
                {
                    var legionName = legionSoldierData.Key;
                    var soldiersData = legionSoldierData.Value;

                    foreach (var soldierPair in soldiersData)
                    {
                        if (soldierPair.Key == givenSoldierType)
                        {
                            notSorted.Add(legionName, soldierPair.Value);
                        }
                    }
                }

                var sorted = notSorted.OrderByDescending(pair => pair.Value);

                #endregion


                foreach (var legionSoldierCount in sorted)
                {
                    var legionName = legionSoldierCount.Key;

                    if (legionAndActivity[legionName] < givenActivity)
                    {
                        Console.WriteLine($"{legionName} -> {legionSoldierCount.Value}");
                    }
                }
            }
            else
            {
                var sortedLegionActivities = legionAndActivity.OrderByDescending(pair => pair.Value);
                foreach (var legionActivityPair in sortedLegionActivities)
                {
                    var legionName = legionActivityPair.Key;
                    var activity = legionActivityPair.Value;

                    var soldiersData = legionsData[legionName];

                    if (soldiersData.ContainsKey(inputLine))
                    {
                        Console.WriteLine($"{legionActivityPair.Value} : {legionActivityPair.Key}");
                    }
                }
            }
        }
    }
}
