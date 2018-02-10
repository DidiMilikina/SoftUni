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
            int[] indexes = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
          

            for (int i = 0; i < drivers.Length; i++)
            {
                int lastZone = -1;
                char firstLetterDriver = drivers[i][0];
                double fuel = firstLetterDriver;

                for (int j = 0; j < zones.Length; j++)
                {
                    if (indexes.Contains(j))
                    {
                        fuel += zones[j];
                    }
                    else
                    {
                        fuel -= zones[j];
                    }

                    if (fuel <= 0)
                    {
                        lastZone = j;
                        break;
                    }
                }

                if (lastZone != -1)
                {
                    Console.WriteLine($"{drivers[i]} - reached {lastZone}");
                }
                else
                {
                    Console.WriteLine($"{drivers[i]} - fuel left {fuel:f2}");
                }
            }
      
        }

    }
}

