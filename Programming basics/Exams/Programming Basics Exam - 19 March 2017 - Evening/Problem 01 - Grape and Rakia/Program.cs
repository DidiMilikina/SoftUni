using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01___Grape_and_Rakia
{
    class Program
    {
        static void Main(string[] args)
        {
            var areaVineyard = double.Parse(Console.ReadLine());
            var kilogrammes = double.Parse(Console.ReadLine());
            var loss = double.Parse(Console.ReadLine());

            var grape = areaVineyard * kilogrammes;
            var grapes = grape - loss;

            var forRakia = 0.45 * grapes;
            var rakiaInLiters = forRakia / 7.5;
            var profitRakia = rakiaInLiters * 9.8;

            var forSell = grapes * 0.55;
            var profit = forSell * 1.5;
            Console.WriteLine($"{profitRakia:F2}");
            Console.WriteLine($"{profit:F2}");
        }
    }
}
