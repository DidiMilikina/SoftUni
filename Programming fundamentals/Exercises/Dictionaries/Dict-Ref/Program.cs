using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dict_Ref
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var resultDictionary = new Dictionary<string, int>();

            while (line != "end")
            {
                var tokens = line.Split();
                var firstElement = tokens[0];
                var lastElement = tokens[tokens.Length - 1];

                var number = 0;
                if (int.TryParse(lastElement, out number))
                {
                    resultDictionary[firstElement] = number;
                }
                else
                {
                    if (resultDictionary.ContainsKey(lastElement))
                    {
                        var referencedValue = resultDictionary[lastElement];
                        resultDictionary[firstElement] = referencedValue;
                    }
                }

                line = Console.ReadLine();
            }

            foreach (var keyValuePair in resultDictionary)
            {
                var name = keyValuePair.Key;
                var price = keyValuePair.Value;
                Console.WriteLine($"{name} === {price}");
            }
        }
    }
}