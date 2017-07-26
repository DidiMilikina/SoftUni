using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3.Финален_конкурс
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberDancers = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();

            var percents = 0.0;
            var money = 0.0;
            if (place == "Bulgaria")
            {
                money = points * numberDancers;
            }
            else
            {
                money = points * numberDancers * 1.5;
            }
            if (season == "summer" && place == "Bulgaria")
            {
                money *= 0.95;
            }
            else if (season == "winter" && place == "Bulgaria")
            {
                money *= 0.92;
            }
            else if (season == "winter" && place == "Abroad")
            {
                money *= 0.85;
            }
            else
            {
                money *= 0.9;
            }

            var moneyCharity = money * 0.75;
            var moneyLeft = money - moneyCharity;
            var moneyPerDancer = moneyLeft / numberDancers;

            Console.WriteLine($"Charity - {moneyCharity:f2}");
            Console.WriteLine($"Money per dancer - {moneyPerDancer:f2}");

        }
    }
}
