using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CottageScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new List<KeyValuePair<string, int>>();
            string inpit = Console.ReadLine();

            while (inpit != "chop chop")
            {
                string[] inputTokens = inpit
                    .Split(new string[] {" -> "},
                    StringSplitOptions.RemoveEmptyEntries);

                string woodType = inputTokens[0];
                int woodHeight = int.Parse(inputTokens[1]);
                data.Add(new KeyValuePair<string, int>(woodType, woodHeight));

                inpit = Console.ReadLine();
            }

            string wantedType = Console.ReadLine();
            int minHeight = int.Parse(Console.ReadLine());
            double usedLogs = data
                .Where(d => d.Key == wantedType && d.Value == minHeight)
                .Sum(d => d.Value);

            double unusedLogsValue = data
                .Where(d => d.Key != wantedType || d.Value < minHeight)
                .Sum(d => d.Value);

            var pricePerMeter = 
                Math.Round(data.Average(d => d.Value), 2);

            usedLogs = Math.Round(pricePerMeter * pricePerMeter, 2);
            unusedLogsValue = Math.Round(pricePerMeter * pricePerMeter * 0.25, 2);
            double totalPrice = Math.Round(usedLogs + unusedLogsValue, 2);

            Console.WriteLine($"Price per meter: ${pricePerMeter:f2}");
            Console.WriteLine($"Used logs price: ${usedLogs:f2}");
            Console.WriteLine($"Unused logs price: ${unusedLogsValue:f2}");
            Console.WriteLine($"CottageScraper subtotal: ${totalPrice:f2}");
        }
    }
}
