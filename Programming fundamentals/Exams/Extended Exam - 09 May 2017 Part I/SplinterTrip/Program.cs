using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplinterTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double tripDistanceInMiles = double.Parse(Console.ReadLine());
            double fuelTankCapacityInLiters = double.Parse(Console.ReadLine());
            double milesSpentInHeavyWinds = double.Parse(Console.ReadLine());

            double milesInNonHeavyWinds = tripDistanceInMiles - milesSpentInHeavyWinds;
            double nonHeavyConsumption = milesInNonHeavyWinds * 25;
            double heavyWindsConsumption = milesSpentInHeavyWinds * (25 * 1.5);
            double fuelConsumption = nonHeavyConsumption + heavyWindsConsumption;
            double tolerance = fuelConsumption * 0.05;
            double totalFuelConsumption = fuelConsumption + tolerance;

            Console.WriteLine($"Fuel needed: {totalFuelConsumption:f2}L");
            if (fuelTankCapacityInLiters >= totalFuelConsumption)
            {
                double enough = fuelTankCapacityInLiters - totalFuelConsumption;
                Console.WriteLine($"Enough with {enough:f2}L to spare!");
            }
            else
            {
                double need = totalFuelConsumption - fuelTankCapacityInLiters;
                Console.WriteLine($"We need {Math.Abs(need):f2}L more fuel.");
            }
        }
    }
}
