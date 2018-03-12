using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            var boughtChrysanthemums = int.Parse(Console.ReadLine());
            var boughtRoses = int.Parse(Console.ReadLine());
            var boughtTylips = int.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var day = Console.ReadLine();

            var priceOfChrysanthemums = 0.0;
            if (season == "Spring" || season == "Summer")
            {
                priceOfChrysanthemums = 2.00;
            }
            else
            {
                priceOfChrysanthemums = 3.75;
            }

            var priceOfRoses = 0.0;
            if (season == "Spring" || season == "Summer")
            {
                priceOfRoses = 4.10;
            }
            else
            {
                priceOfRoses = 4.50;
            }

            var priceOfTylips = 0.0;
            if (season == "Spring" || season == "Summer")
            {
                priceOfTylips = 2.50;
            }
            else
            {
                priceOfTylips = 4.15;
            }

            var totalPrice = priceOfChrysanthemums * boughtChrysanthemums + priceOfRoses * boughtRoses + priceOfTylips * boughtTylips;

            if (day == "Y")
            {
                totalPrice = totalPrice * 1.15;
            }

            if (boughtTylips > 7 && season == "Spring")
            {
                totalPrice = totalPrice - totalPrice * 0.05;
            }
            if (boughtRoses >= 10 && season == "Winter")
            {
                totalPrice = totalPrice - totalPrice * 10 / 100;
            }
            if (boughtTylips + boughtRoses + boughtChrysanthemums > 20)
            {
                totalPrice = totalPrice - totalPrice * 20 / 100;
            }

            totalPrice = totalPrice + 2;
            Console.WriteLine($"{totalPrice:f2}");



        }
    }
}
