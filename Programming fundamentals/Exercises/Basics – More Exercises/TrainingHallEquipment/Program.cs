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
            int budget = int.Parse(Console.ReadLine());
            int numberOfItems = int.Parse(Console.ReadLine());
            string itemName = Console.ReadLine();
            double itemPrice = double.Parse(Console.ReadLine());
            int itemCount = int.Parse(Console.ReadLine());

            double couter = 0;

            double sum = itemPrice * itemCount;
            for (int i = 1; i <= numberOfItems; i++)
            {

                if(itemCount < 2)
                {
                    Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {itemCount} {itemName}s to cart.");
                }
            }

            Console.WriteLine($"Subtoal: ${itemPrice}");

            if (budget >= itemPrice)
            {
                double moneyLeft = budget - itemPrice;
                Console.WriteLine($"Money left: ${moneyLeft:f2}");
            }
            else
            {
                Console.WriteLine($"Not enough.We need ${(itemPrice - budget):f2} more.");
            }
        }
    }
}
