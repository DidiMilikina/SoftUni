using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var pairs = new Dictionary<string, string>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputParams = input.Split(new[] { ' ', '-', '>' },
                    StringSplitOptions.RemoveEmptyEntries);

                string key = inputParams[0];
                string value = inputParams[1];
                
                // Update value everytime.
                pairs[key] = value;

                input = Console.ReadLine();
            }

            string defaultValue = Console.ReadLine();

            Dictionary<string, string> unchangedValues = pairs
                .Where(x => x.Value != "null")
                .OrderByDescending(x => x.Value.Length)
                .ToDictionary(x => x.Key, x => x.Value);

            Dictionary<string, string> changedValues = pairs
                .Where(x => x.Value == "null")
                .ToDictionary(x => x.Key, x => defaultValue);


            foreach (var unchanged in unchangedValues)
            {
                Console.WriteLine($"{unchanged.Key} <-> {unchanged.Value}");
            }
            foreach (var changed in changedValues)
            {
                Console.WriteLine($"{changed.Key} <-> {changed.Value}");
            }
        }
    }
}
