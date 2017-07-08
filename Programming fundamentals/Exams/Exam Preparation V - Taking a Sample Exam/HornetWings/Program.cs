using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetWings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            var totalDistance = wingFlaps / 1000 * distance;
            var seconds = wingFlaps / 100;
            var rest = wingFlaps / endurance * 5;
            var restInSeconds = seconds + rest;

            Console.WriteLine($"{totalDistance:f2} m.");
            Console.WriteLine($"{restInSeconds} s.");

        }
    }
}