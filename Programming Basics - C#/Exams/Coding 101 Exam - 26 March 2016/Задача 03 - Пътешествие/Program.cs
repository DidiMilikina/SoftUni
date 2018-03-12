using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if (budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (season == "summer")
                {
                    var spend = budget / 100 * 30;
                    Console.WriteLine("Camp - {0:F2}", spend);
                }
                else if (season == "winter")
                {
                    var spend = budget / 100 * 70;
                    Console.WriteLine("Hotel - {0:F2}", spend);
                }
            }
            else if (budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season == "summer")
                {
                    var spend = budget / 100 * 40;
                    Console.WriteLine("Camp - {0:F2}", spend);
                }
                else if (season == "winter")
                {
                    var spend = budget / 100 * 80;
                    Console.WriteLine("Hotel - {0:F2}", spend);
                }
            }
            else
            {
                Console.WriteLine("Somewhere in Europe");
                var spend = budget / 100 * 90;
                Console.WriteLine("Hotel - {0:F2}", spend);
            }

        }
    }
}