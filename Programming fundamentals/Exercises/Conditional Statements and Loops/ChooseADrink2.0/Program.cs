using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseADrink2._0
{
    class Program
    {
        static void Main(string[] args)
        {

            string profession = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            
            if (profession == "Athlete")
            {
                double price = 0.70;
                double totalPrice = quantity * price;
                Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                double price = 1.00;
                double totalPrice = quantity * price;
                Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
            }
            else if (profession == "SoftUni Student")
            {
                double price = 1.70;
                double totalPrice = quantity * price;
                Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
            }
            else
            {
                double price = 1.20;
                double totalPrice = quantity * price;
                Console.WriteLine($"The {profession} has to pay {totalPrice:f2}.");
            }
        }
    }
}
