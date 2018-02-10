using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCoffeeSupplies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] delimetersInput = Console.ReadLine()
                .Split();
            string firstDelimeterInput = delimetersInput[0];
            string secondDelimeterInput = delimetersInput[1];

            string command = Console.ReadLine();

            var coffeeTypeAllPersons = new Dictionary<string, string>();
            var coffeeQuantity = new Dictionary<string, int>();

            while (!command.Equals("end of info"))
            {
                if (command.Contains(firstDelimeterInput))
                {
                    int indexDelimeter = command.IndexOf(firstDelimeterInput);
                    string name = command.Substring(0, indexDelimeter);
                    string typeCoffee = command.Substring(indexDelimeter + firstDelimeterInput.Length);

                    if (!coffeeTypeAllPersons.ContainsKey(name))
                    {
                        coffeeTypeAllPersons.Add(name, typeCoffee);
                    }
                    coffeeTypeAllPersons[name] = typeCoffee;

                    if (!coffeeQuantity.ContainsKey(typeCoffee))
                    {
                        coffeeQuantity.Add(typeCoffee, 0);
                    }
                }

                else
                {
                    int indexDelimeter = command.IndexOf(secondDelimeterInput);
                    string typeCoffee = command.Substring(0, indexDelimeter);
                    int quantityCoffee = int.Parse(command.Substring(indexDelimeter + secondDelimeterInput.Length));


                    if (!coffeeQuantity.ContainsKey(typeCoffee))
                    {
                        coffeeQuantity.Add(typeCoffee, quantityCoffee);
                    }
                    coffeeQuantity[typeCoffee] = quantityCoffee;

                }
                command = Console.ReadLine();
            }

            foreach (var outCoffee in coffeeQuantity)
            {
                if (outCoffee.Value <= 0)
                {
                    var coffeeType = outCoffee.Key;
                    Console.WriteLine($"Out of {coffeeType}");
                }
            }

            while (!command.Equals("end of week"))
            {
                string[] tokens = command
                    .Split();
                string personName = tokens[0];
                int quantity = int.Parse(tokens[1]);

                if ()
                {
                    var coffeeType = outCoffee.Key;
                    Console.WriteLine($"Out of {coffeeType}");
                }
                command = Console.ReadLine();
            }

            Console.WriteLine("Coffee Left:");


            Console.WriteLine("For:");
        }
    }
}
