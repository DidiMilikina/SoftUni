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
            double distanceInMeters = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            var distance = (wingFlaps / 1000) * distanceInMeters;
            var flaps = wingFlaps / 100;
            var rest = wingFlaps / endurance * 5;
            var totalRest = flaps + rest;
            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{totalRest} s.");
        }
    }
}
