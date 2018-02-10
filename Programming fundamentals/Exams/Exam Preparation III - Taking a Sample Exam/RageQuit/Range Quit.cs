using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(\D+)(\d+)");
            string input = Console.ReadLine();
            MatchCollection matches = regex.Matches(input);
            StringBuilder result = new StringBuilder();

            foreach (Match match in matches)
            {
                string partition = match.Groups[1].Value;
                int times = int.Parse(match.Groups[2].Value);

                result.Append(Repeat(partition, times).ToUpper());
            }

            int count = result.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {count}");
            Console.WriteLine(result);
        }

        private static string Repeat(string partition, int times)
        {
            StringBuilder final = new StringBuilder();
            for (int i = 0; i < times; i++)
            {
                final.Append(partition);
            }
            return final.ToString();
        }
    }
    }
}
