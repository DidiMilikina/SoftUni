using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceYiskiLv = double.Parse(Console.ReadLine());
            var colBeer = double.Parse(Console.ReadLine());
            var colVine = double.Parse(Console.ReadLine());
            var colRakia = double.Parse(Console.ReadLine());
            var colYiski = double.Parse(Console.ReadLine());

            var priceRakiaPerL = priceYiskiLv / 2;
            var priceVinePerL = priceRakiaPerL - (0.4 * priceRakiaPerL);
            var priceBeerPerL = priceRakiaPerL - (0.8 * priceRakiaPerL);
            var sumRakia = colRakia * priceRakiaPerL;
            var sumVine = colVine * priceVinePerL;
            var sumBeer = priceBeerPerL * colBeer;
            var sumUiski = colYiski * priceYiskiLv;
            var total = sumBeer + sumRakia + sumUiski + sumVine;
            Console.WriteLine($"{total:F2}");

        }
    }
}
