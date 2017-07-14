using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            var travelDict = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(':');
                string city = input[0];

                if (city == "ready")
                {
                    break;
                }

                string[] transportAndCapacity = input[1]
                    .Split(',');
                if (!travelDict.ContainsKey(city))
                {
                    travelDict.Add(city, new Dictionary<string, int>());
                }
                for (int i = 0; i < transportAndCapacity.Length; i++)
                {
                    string[] transportFormat = transportAndCapacity[i]
                        .Split('-');
                    string transportType = transportFormat[0];
                    int capacity = int.Parse(transportFormat[1]);
                    if (!travelDict[city].ContainsKey(transportType))
                    {
                        travelDict[city].Add(transportType, 0);
                    }
                    travelDict[city][transportType] = capacity;
                }
            }

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "travel time!")
                {
                    break;
                }
                string[] command = input.Split(' ');
                string travelCity = command[0];
                int travelPeople = int.Parse(command[1]);

                foreach (var item in travelDict)
                {
                    if (item.Key == travelCity)
                    {
                        int capacitySum = 0;
                        foreach (var capacity in travelDict[travelCity])
                        {
                            capacitySum += capacity.Value;
                        }
                        if (capacitySum >= travelPeople)
                        {
                            Console.WriteLine($"{travelCity} -> all {travelPeople} accommodated");
                        }
                        else
                        {
                            Console.WriteLine($"{travelCity} -> all except {travelPeople - capacitySum} " +
                                              $"accommodated");
                        }
                    }
                }
            }
        }
    }
}