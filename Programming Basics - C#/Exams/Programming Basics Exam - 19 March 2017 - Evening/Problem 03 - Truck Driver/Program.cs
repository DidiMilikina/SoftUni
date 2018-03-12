using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03___Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Console.ReadLine();
            var kmPerMonth = double.Parse(Console.ReadLine());
            var price = 0.0;

            if (kmPerMonth <= 5000)
            {
                if(season == "Spring" || season == "Autumn")
                {
                    price = kmPerMonth * 0.75;
                }
                else if(season == "Summer")
                {
                    price = kmPerMonth * 0.9;
                }
                else
                {
                    price = kmPerMonth * 1.05;
                }
            }
            else if (kmPerMonth > 5000  && kmPerMonth <= 10000)
            {

                if (season == "Spring" || season == "Autumn")
                {
                    price = kmPerMonth * 0.95;
                }
                else if (season == "Summer")
                {
                    price = kmPerMonth * 1.1;
                }
                else
                {
                    price = kmPerMonth * 1.25;
                }
            }
            else
            {
                price = kmPerMonth * 1.45;
            }

            var priceWithTenPercent = (price * 4);
            priceWithTenPercent *= 0.9;
            Console.WriteLine($"{priceWithTenPercent:f2}");
        }
    }
}
