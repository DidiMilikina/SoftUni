using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfMagnolias = int.Parse(Console.ReadLine());
            var numberOfHyacinths = int.Parse(Console.ReadLine());
            var numberOfRoses = int.Parse(Console.ReadLine());
            var numberOfCactus = int.Parse(Console.ReadLine());
            var priceForPresent = double.Parse(Console.ReadLine());

            var price = numberOfMagnolias * 3.25 + numberOfHyacinths * 4.0 + numberOfRoses * 3.5 + numberOfCactus * 8.0;
            var money = price - (price * 0.05);

            if (priceForPresent <= money)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(money - priceForPresent));
            }
            else 
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(priceForPresent - money));
            }
        }
    }
}
