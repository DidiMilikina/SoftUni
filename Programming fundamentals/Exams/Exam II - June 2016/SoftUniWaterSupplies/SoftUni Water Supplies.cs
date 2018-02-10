using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniWaterSupplies
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountWater = double.Parse(Console.ReadLine());
            double[] bottlesNeedToFill = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            double capacityEachBottle = double.Parse(Console.ReadLine());

            var waterInAllBottles = bottlesNeedToFill.Sum();
            var neededWater = bottlesNeedToFill.Length * capacityEachBottle - waterInAllBottles;

            if (amountWater - neededWater >= 0)
            {
                var left = amountWater - neededWater;
                Console.WriteLine("Enough water!");
                Console.WriteLine($"Water left: {left}l.");
            }
            else
            {
                Console.WriteLine("We need more water!");

                var leftWater = neededWater - amountWater;
                int leftBottles = 0;
                var indexesOfBottles = new List<int>();

                if (amountWater % 2 == 0)
                {
                    for (int i = 0; i < bottlesNeedToFill.Length; i++)
                    {
                        double currentBottle = bottlesNeedToFill[i];
                        double quantityToFill = capacityEachBottle - currentBottle;
                        if (amountWater >= quantityToFill)
                        {
                            amountWater -= quantityToFill;
                        }
                        else
                        {
                            amountWater = 0;
                            leftBottles++;
                            indexesOfBottles.Add(i);
                        }
                    }
                }
                else
                {
                    for (int i = bottlesNeedToFill.Length - 1; i >= 0; i--)
                    {
                        double currentBottle = bottlesNeedToFill[i];
                        double quantityToFill = capacityEachBottle - currentBottle;
                        if (amountWater >= quantityToFill)
                        {
                            amountWater -= quantityToFill;
                        }
                        else
                        {
                            amountWater = 0;
                            leftBottles++;
                            indexesOfBottles.Add(i);
                        }
                    }
                }

                Console.WriteLine($"Bottles left: {leftBottles}");
                Console.WriteLine("With indexes: {0}", string.Join(", ", indexesOfBottles));
                Console.WriteLine($"We need {leftWater} more liters!");
            }
        }
    }
}
