using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            int numberOfNightsToSubtract = 0;

            double studioPrice;
            double doublePrice;
            double suitePrice;

            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                doublePrice = 65;
                suitePrice = 75;

                if (month == "October" && nights > 7)
                {
                    numberOfNightsToSubtract = 1;
                }

                if (nights > 7)
                {
                    studioPrice *= 0.95;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 60;
                doublePrice = 72;
                suitePrice = 82;

                if (month == "September" && nights > 7)
                {
                    numberOfNightsToSubtract = 1;
                }

                if (nights > 14)
                {
                    doublePrice *= 0.9;
                }

            }
            else
            {
                studioPrice = 68;
                doublePrice = 77;
                suitePrice = 89;

                if (nights > 14)
                {
                    suitePrice *= 0.85;
                }

            }


            double finalPriceForStudio = (nights - numberOfNightsToSubtract) * studioPrice;
            double finalPriceForDouble = nights * doublePrice;
            double finalPriceForSuite = nights * suitePrice;

            Console.WriteLine($"Studio: {finalPriceForStudio:f2} lv.");
            Console.WriteLine($"Double: {finalPriceForDouble:f2} lv.");
            Console.WriteLine($"Suite: {finalPriceForSuite:f2} lv.");
        }
    }
}
