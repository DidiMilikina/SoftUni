using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenghtInMeters = int.Parse(Console.ReadLine());
            double widthInCentimeters = double.Parse(Console.ReadLine());

            lenghtInMeters *= 100;
            double remaining = lenghtInMeters % widthInCentimeters;

            if (widthInCentimeters == 0)
            {
                Console.WriteLine($"{lenghtInMeters * widthInCentimeters:f2}");
            }
            else
            {
                if (remaining != 0)
                {
                    double inPercents = (lenghtInMeters / widthInCentimeters) * 100;
                    Console.WriteLine($"{inPercents:f2}%");
                }
                else
                {
                    Console.WriteLine($"{lenghtInMeters * widthInCentimeters:f2}");
                }
            }
        }
    }
}