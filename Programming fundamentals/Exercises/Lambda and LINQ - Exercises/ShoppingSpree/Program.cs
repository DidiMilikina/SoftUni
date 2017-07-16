using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            var storage = new Dictionary<string, decimal>();

            while (input != "end")
            {
                List<string> products = input
                    .Split(' ')
                    .ToList();
                string product = products[0];
                decimal price = decimal.Parse(products[1]);

                if (!storage.ContainsKey(product))
                {
                    storage.Add(product, price);
                }
                else
                {
                    Dictionary<string, decimal> tempDictionary = storage
                        .Where(x => x.Key == product)
                        .Where(x => x.Value > price)
                        .ToDictionary(x => x.Key, x => price);

                    foreach (var kvp in tempDictionary)
                    {
                        storage[kvp.Key] = kvp.Value;
                    }
                }
                input = Console.ReadLine();
            }

            if (budget >= storage.Sum(x => x.Value))
            {
                storage
                     .OrderBy(x => x.Key.Length)
                     .OrderByDescending(x => x.Value)
                     .ToList()
                     .ForEach(x => Console.WriteLine($"{x.Key} costs {x.Value:f2}"));
            }
            else
            {
                Console.WriteLine("Need more money... Just buy banichka");
            }
        }
    }
}