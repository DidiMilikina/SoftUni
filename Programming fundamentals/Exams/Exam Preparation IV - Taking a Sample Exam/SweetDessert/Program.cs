using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweetDessert
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountCash = double.Parse(Console.ReadLine());
            double numberGuests = double.Parse(Console.ReadLine());
            double priceBananas = double.Parse(Console.ReadLine());
            double priceEggs = double.Parse(Console.ReadLine());
            double priceBerriesPerKg = double.Parse(Console.ReadLine());

            var guests = 6;

            var allGuests = Math.Ceiling(numberGuests / guests);
            var price =
                allGuests * (2 * priceBananas) +
                allGuests * (4 * priceEggs) +
                allGuests * (0.2 * priceBerriesPerKg);

            if (amountCash >= price)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {price:f2}lv.");
            }
            else
            {
                var needed = price - amountCash;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {needed:f2}lv more.");
            }
        }
    }
}
