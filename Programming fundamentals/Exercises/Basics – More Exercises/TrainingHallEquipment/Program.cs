using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingHallEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            byte itemsNumber = byte.Parse(Console.ReadLine());

            string itemsName;
            double itemsPrice;
            short itemsCount;
            double total = 0;

            for (byte i = 1; i <= itemsNumber; i++)
            {
                itemsName = Console.ReadLine();
                itemsPrice = double.Parse(Console.ReadLine());
                itemsCount = short.Parse(Console.ReadLine());

                if (itemsCount > 1)
                {
                    itemsName += "s";
                }

                total += itemsCount * itemsPrice;

                Console.WriteLine($"Adding {itemsCount} {itemsName} to cart.");
            }

            Console.WriteLine("Subtotal: ${0:f2}", total);

            if (total > budget)
            {
                double moneyLeft = total - budget;
                Console.WriteLine($"Not enough. We need ${moneyLeft:f2} more.");
            }
            else
            {
                Console.WriteLine($"Money left: ${budget - total:f2}");
            }
        }
    }
  }