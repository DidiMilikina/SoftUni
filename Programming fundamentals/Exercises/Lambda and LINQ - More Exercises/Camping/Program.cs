using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camping
{
    class Program
    {
        static void Main(string[] args)
        {
            var campersData = new Dictionary<string, List<string>>();
            var daysData = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputTokens = input.Split(' ');
                string name = inputTokens[0];
                string camperName = inputTokens[1];
                int dayStayed = int.Parse(inputTokens[2]);

                if (!campersData.ContainsKey(name))
                {
                    campersData.Add(name, new List<string>());
                }
                campersData[name].Add(camperName);

                if (!daysData.ContainsKey(name))
                {
                    daysData.Add(name, 0);
                }
                daysData[name] += dayStayed;

                input = Console.ReadLine();
            }
            var orderData = campersData
                .OrderByDescending(d => d.Value.Count)
                .ThenBy(d => d.Key.Length);

            foreach (var data in orderData)
            {
                string key = data.Key;
                List<string> campers = data.Value;

                Console.WriteLine($"{key}: {campers.Count}");
                foreach (var camp in campers)
                {
                    Console.WriteLine($"***{camp}");
                }

                Console.WriteLine($"Total stay: {daysData[key]} nights");
            }
        }
    }
}
