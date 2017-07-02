using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batteries
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentBatterCapacity = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var usagesPerHour = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            int amountPerHours = int.Parse(Console.ReadLine());

            var originalBatteryCapacities = new List<double>();
            for (int i = 0; i < currentBatterCapacity.Length; i++)
            {
                originalBatteryCapacities.Add(currentBatterCapacity[i]);
                for (int j = 0; j < amountPerHours; j++)
                {
                    currentBatterCapacity[i] -= usagesPerHour[i];
                    if (currentBatterCapacity[i] <= 0)
                    {                       
                        Console.WriteLine($"Battery {i + 1}: dead (lasted {j + 1} hours)");
                        break;
                    } 
                }

                if (currentBatterCapacity[i] > 0)
                {
                    double percents = (currentBatterCapacity[i] / originalBatteryCapacities[i]) * 100;
                    Console.WriteLine($"Battery {i + 1}: {currentBatterCapacity[i]:f2} mAh ({percents:f2})%");
                }                
            }            
        }
    }
}