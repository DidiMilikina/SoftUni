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
            decimal amountCash = decimal.Parse(Console.ReadLine());
            decimal numGuests = decimal.Parse(Console.ReadLine());
            decimal priceBanana = decimal.Parse(Console.ReadLine());
            decimal priceEgg = decimal.Parse(Console.ReadLine());
            decimal priceBerriesKilo = decimal.Parse(Console.ReadLine());

            decimal sets = Math.Ceiling(numGuests / 6);
            decimal bananasneeded = sets * 2;
            decimal berriesneeded = sets * (decimal)0.2;
            decimal eggsneeded = sets * 4;
            decimal priceforproductsneeded = bananasneeded * priceBanana + berriesneeded * priceBerriesKilo +
                                             eggsneeded * priceEgg;

            if (priceforproductsneeded <= amountCash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {priceforproductsneeded:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {Math.Abs(priceforproductsneeded - amountCash):f2}lv more.");
            }
        }
    }
}
