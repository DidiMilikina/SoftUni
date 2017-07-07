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
            int countOrders = int.Parse(Console.ReadLine());
            var totalSum = 0.0M;

            for (int i = 0; i < countOrders; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());

                var date = 
                    DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);

                long capsulesCount = long.Parse(Console.ReadLine());
                var month = date.Month;
                var year = date.Year;
                int days = DateTime.DaysInMonth(year, month);

                var price = ((days * capsulesCount) * pricePerCapsule);
                totalSum += price;

                Console.WriteLine($"The price for the coffee is: ${price:f2}");
            }

            Console.WriteLine($"Total: ${totalSum:f2}");
        }
    }
}