using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02___Styrofoam
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var areaOfHouse = double.Parse(Console.ReadLine());
            var windows = int.Parse(Console.ReadLine());
            var styrofoamInOnePack = double.Parse(Console.ReadLine());
            var styrofoamPrice = double.Parse(Console.ReadLine());

            var areaHouse = areaOfHouse - windows * 2.4;
            var add10Percent = areaHouse * 1.1; 
            var neededPacks = add10Percent / styrofoamInOnePack;
            neededPacks = Math.Ceiling(neededPacks);
            var pricePacks = neededPacks * styrofoamPrice;
            if(budget >= pricePacks)
            {
                Console.WriteLine($"Spent: {pricePacks:F2} ");
                Console.WriteLine($"Left: {budget - pricePacks:F2}");
            }
            else
            {
                Console.WriteLine($"Need more: {pricePacks - budget:F2}");
            }

        }
    }
}
