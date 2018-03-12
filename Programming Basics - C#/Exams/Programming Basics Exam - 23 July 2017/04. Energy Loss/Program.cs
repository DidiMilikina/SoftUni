using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Energy_Loss
{
    class Program
    {
        static void Main(string[] args)
        {
            var trainDays = int.Parse(Console.ReadLine());
            var numberDancers = int.Parse(Console.ReadLine());

            
            double totalEnergy =  100 * numberDancers * trainDays;
            double totalEnergyUsed = 0;

            for (int i = 1; i <= trainDays; i++)
            {
                int hoursinput = int.Parse(Console.ReadLine());
                bool train = i % 2 == 0;
                bool hours = hoursinput % 2 == 0;
                double energyFirst = 0;

                if (train && hours)
                {
                    energyFirst = 68;

                }
                else if (!train && hours)
                {
                    energyFirst = 49;
                }
                else if (!train && !hours)
                {
                    energyFirst = 30;
                }
                else
                {
                    energyFirst = 65;
                }

                double currentEnergyUsed = energyFirst * numberDancers;
                totalEnergyUsed += currentEnergyUsed;
            }

            double energyLeft = totalEnergy - totalEnergyUsed;
            var energyPerDancer = energyLeft / numberDancers / trainDays;

            if (energyPerDancer <= 50)
            {
                Console.WriteLine($"They are wasted! Energy left: {energyPerDancer:f2}");
            }
            else
            {
                Console.WriteLine($"They feel good! Energy left: {energyPerDancer:f2}");
            }
        }
    }
}