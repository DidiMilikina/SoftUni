using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostValuedCustomer
{
    class Program
    {
        static void Main(string[] args)
        {
            var inventory = new Dictionary<string, double>();
            var productsInput = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input != "Shop is open")
            {
                string[] inputTokens = input.Split(' ');
                string product = inputTokens[0];
                double price = double.Parse(inputTokens[1]);

                inventory[product] = price;
                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "Print")
            {
                string[] inputTokens = Console.ReadLine()
                    .Split(new string[] {",", ": "}, 
                    StringSplitOptions.RemoveEmptyEntries);

                if (inputTokens[0] == "Discount")
                {
                    var discountProducts = inventory
                        .OrderByDescending(p => p.Value)
                        .Take(3)
                        .Select(p => new KeyValuePair<string, double>(p.Key, p.Value * 0.9));

                    foreach (var discountProduct in discountProducts)
                    {
                        inventory[discountProduct.Key] = discountProduct.Value;
                    }
                }
                else
                {
                    string product = inputTokens[0];
                    if (!productsInput.ContainsKey(product))
                    {
                        productsInput.Add(product, new List<string>());
                    }
                    for (int i = 1; i < inputTokens.Length; i++)
                    {
                        string boughtProducts = inputTokens[i];
                        if (inventory.ContainsKey(boughtProducts))
                        {
                            productsInput[product].Add(boughtProducts);
                        }
                    }
                }
                input = Console.ReadLine();
            }

           
        }
    }
}
