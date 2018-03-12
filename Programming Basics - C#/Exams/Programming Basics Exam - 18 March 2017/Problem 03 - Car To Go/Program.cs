using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03___Car_To_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();

            if (budget <= 100)
            {
                Console.WriteLine("Economy class");
                if(season == "Summer")
                {
                    Console.WriteLine($"Cabrio - {budget * 35 / 100:F2}");
                }
                else
                {
                    Console.WriteLine($"Jeep - {budget * 65 / 100:F2}");
                }
            }
            else if (budget > 100 && budget <= 500)
            {
                Console.WriteLine("Compact class");
                if(season == "Summer")
                {
                    Console.WriteLine($"Cabrio - {budget * 45 / 100:F2}");
                }
                else
                {
                    Console.WriteLine($"Jeep - {budget * 80 / 100:F2}");
                }
            }
            else
            {
                Console.WriteLine("Luxury class");
                Console.WriteLine($"Jeep - {budget * 90 / 100:F2}");
            }
           
        }
    }
}
