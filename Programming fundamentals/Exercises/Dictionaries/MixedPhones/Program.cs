using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixedPhones
{
    class Program
    {
        static void Main(string[] args)
        {
            var namePhones = new SortedDictionary<string, decimal>();
            var line = Console.ReadLine();

            while (line != "Over")
            {
                var tokens = line.Split(" :".ToCharArray(),
                     StringSplitOptions.RemoveEmptyEntries);

                var firstElement = tokens[0];
                var secondElement = tokens[1];

                var phoneNumber = 0m;
                if (decimal.TryParse(firstElement, out phoneNumber))
                {
                    namePhones[secondElement] = phoneNumber;
                }
                else if(decimal.TryParse(secondElement, out phoneNumber))
                {
                    namePhones[firstElement] = phoneNumber;
                }
                
                 line = Console.ReadLine();
            }

            foreach (var nameNumber in namePhones)
            {
                var name = nameNumber.Key;
                var number = nameNumber.Value;

                Console.WriteLine($"{name} -> {number}");
            }
        }
    }
}