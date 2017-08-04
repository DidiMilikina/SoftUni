using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniCoffeeOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            long countOrders = long.Parse(Console.ReadLine());

            decimal sum = 0;
            for (int i = 0; i < countOrders; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime date = DateTime.ParseExact(Console.ReadLine(),
                    "d/M/yyyy",
                    CultureInfo.InvariantCulture);
                long capsulesCount = long.Parse(Console.ReadLine());

                decimal price = DateTime.DaysInMonth(date.Year, date.Month) * pricePerCapsule * capsulesCount;
                sum += price;
                Console.WriteLine($"The price for the coffee is: ${price:F2}");
            }
            Console.WriteLine($"Total: ${sum:F2}");
        }
    }
}
