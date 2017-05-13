using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var vineyard = int.Parse(Console.ReadLine());
            var grapesPerLiter = double.Parse(Console.ReadLine());
            var neededLiters = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            var total = (vineyard * grapesPerLiter) * 0.4; ;
            var vine = total / 2.5;
            if(vine >= neededLiters)
            {
                var vineLeft = vine - neededLiters;
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(vine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(vineLeft), Math.Ceiling(vineLeft / workers));
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(neededLiters - vine));
            }
        }
    }
}
