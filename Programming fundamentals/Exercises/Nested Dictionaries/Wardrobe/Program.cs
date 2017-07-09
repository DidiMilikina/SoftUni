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
            var numberColours = int.Parse(Console.ReadLine());
            var itemColor = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < numberColours; i++)
            {
                var both = Console.ReadLine()
                    .Split(new string[] { " -> ", ", "},
                        StringSplitOptions.RemoveEmptyEntries);

                string color = both[0];
                string[] clothes = both[1].Split(',');

                if (!itemColor.ContainsKey(color))
                {
                    itemColor.Add(color, new Dictionary<string, int>());
                }

                foreach (var cloth in clothes)
                {
                    var clothBase = itemColor[color];
                    
                    if (!clothBase.ContainsKey(cloth))
                    {
                        clothBase.Add(cloth, 0);
                    }

                    clothBase[cloth]++;
                }

            }
            string[] searchTokens = Console.ReadLine().Split(' ');
            string searchedColor = searchTokens[0];
            string searchedCloth = searchTokens[1];

            
            foreach (var colorData in itemColor)
            {
                var color = colorData.Key;
                var clothData = colorData.Value;

                Console.WriteLine($"{color} clothes:");
                foreach (var item in clothData)
                {
                    string cloth = item.Key;
                    int quantity = item.Value;

                    Console.Write($"* {cloth} - {quantity}");
                    if (color == searchedColor && cloth == searchedCloth)
                    {
                        Console.Write(" (found!)");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
