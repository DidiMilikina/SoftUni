using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            var juniors = int.Parse(Console.ReadLine());
            var seniors = int.Parse(Console.ReadLine());
            var typeOfRaice = Console.ReadLine();

            var juniorsPrice = 0.00;
            var seniorsPrice = 0.00;

            if (typeOfRaice == "trail")
            {
                juniorsPrice = 5.50;
                seniorsPrice = 7.00;
            }
            else if (typeOfRaice == "cross-country")
            {
                if (juniors + seniors >= 50)
                {
                    juniorsPrice = 8.00 * 0.75;
                    seniorsPrice = 9.5 * 0.75;
                }
                else
                {
                    juniorsPrice = 8.00;
                    seniorsPrice = 9.50;
                }
            }
            else if (typeOfRaice == "downhill")
            {
                juniorsPrice = 12.25;
                seniorsPrice = 13.75;
            }
            else
            {
                juniorsPrice = 20.00;
                seniorsPrice = 21.50;
            }

            var collectSum = juniors * juniorsPrice + seniors * seniorsPrice;
            var expense = collectSum * 0.05;
            var collectSumWithoutExpenses = collectSum - expense;
            Console.WriteLine("{0:f2}", collectSumWithoutExpenses);
        }
    }
}
