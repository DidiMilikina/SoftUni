using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSA
{
    class NSA
    {
        static void Main(string[] args)
        {
            var registry = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();

            while (input != "quit")
            {
                var inputParams = input
                    .Split(new[] { " -> ", " " },
                        StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
                var country = inputParams[0];
                var spyName = inputParams[1];
                var daysInService = int.Parse(inputParams[2]);

                if (!registry.ContainsKey(country))
                {
                    registry[country] = new Dictionary<string, int>();
                }
                registry[country][spyName] = daysInService;

                input = Console.ReadLine();
            }

            foreach (var countryResult in registry.OrderByDescending(x => x.Value.Keys.Count))
            {
                Console.WriteLine($"Country: {countryResult.Key}");
                foreach (var nameAndScore in countryResult.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"**{nameAndScore.Key} : {nameAndScore.Value}");
                }
            }
        }
    }
}
