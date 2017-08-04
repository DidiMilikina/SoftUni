using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnduranceRally
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] drivers = Console.ReadLine().Split();
            double[] zones = Console.ReadLine().Split()
                .Select(double.Parse).ToArray();
            double[] indexes = Console.ReadLine().Split()
                .Select(double.Parse).ToArray();

            for (int i = 0; i < drivers.Length; i++)
            {
                char firstLetterDriver = char.Parse(drivers[i].Substring(0, 1));
                double fuel = firstLetterDriver;
                for (int j = 0; j < zones.Length; j++)
                {
                    if (indexes.Contains(j))
                    {
                        fuel += indexes[j];
                    }
                    else
                    {
                        fuel -= indexes[j];
                    }
                    if (fuel < 0)
                    {
                        Console.WriteLine($"{drivers[i]} - reached {j}");
                    }
                    else
                    {
                        Console.WriteLine($"{drivers[i]} - fuel left {fuel:f2}");
                    }
                }
            }
        }
    }
}
