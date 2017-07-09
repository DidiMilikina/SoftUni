using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shellbound
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var regionNameSize = new Dictionary<string, HashSet<int>>();

            while (input != "Aggregate")
            {
                var tokens = input
                    .Split();

                var region = tokens[0];
                var shell = int.Parse(tokens[1]);

                if (!regionNameSize.ContainsKey(region))
                {
                    regionNameSize[region] = new HashSet<int>();
                }
                regionNameSize[region].Add(shell);

                input = Console.ReadLine();
            }

            foreach (var result in regionNameSize)
            {
                var regionResult = result.Key;
                var sizeResult = result.Value;
                var gigantShell = Math.Ceiling(sizeResult.Sum() - sizeResult.Average());

                Console.WriteLine($"{regionResult} -> {string.Join(", ",sizeResult)} ({gigantShell})");
            }
        }
    }
}