using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, List<string>>();
            string keyFirst = Console.ReadLine();
            string valueFirst = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                List<string> pairs = Console.ReadLine().Split().ToList();
                string pairKey = pairs[0];
                List<string> pairValue = pairs[2].Split(';').ToList();

                if (!result.ContainsKey(pairKey))
                {
                    result[pairKey] = new List<string>();
                }
                foreach (var element in pairValue)
                {
                    result[pairKey].Add(element);
                }
                Console.WriteLine();

               
            }
            foreach (var item in result)
            {
                string key = item.Key;
                List<string> value = item.Value;

                if (key.Contains(keyFirst))
                {
                    Console.WriteLine($"{key}:");

                    foreach (var element in value)
                    {
                        if (element.Contains(valueFirst))
                        {
                            Console.WriteLine($"-{element}");
                        }
                    }
                }
            }
        }
    }
}
