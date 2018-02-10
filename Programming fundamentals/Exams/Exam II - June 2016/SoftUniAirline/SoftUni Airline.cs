using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniAirline
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            decimal overall = 0m;

            for (int i = 0; i < num; i++)
            {
                var adultPassengersCount = long.Parse(Console.ReadLine());
                var adultTicketPrice = decimal.Parse(Console.ReadLine());
                var youthPassengersCount = long.Parse(Console.ReadLine());
                var youthTicketPrice = decimal.Parse(Console.ReadLine());
                var fuelPricePerHour = decimal.Parse(Console.ReadLine());
                var fuelConsumptionPerHour = decimal.Parse(Console.ReadLine());
                var flightDuration = long.Parse(Console.ReadLine());
                decimal expenses = flightDuration * fuelConsumptionPerHour * fuelPricePerHour;

                decimal income =
                    adultTicketPrice * adultPassengersCount 
                    + youthTicketPrice * youthPassengersCount;

                decimal profit = income - expenses;
                overall += profit;

                if (income >= expenses)
                {
                    Console.WriteLine("You are ahead with {0:F3}$.", profit);
                }
                else
                {
                    Console.WriteLine("We've got to sell more tickets! We've lost {0:F3}$.", profit);
                }
            }

            decimal avg = overall / num;
            Console.WriteLine($"Overall profit -> {overall:f3}$.");
            Console.WriteLine($"Average profit -> {avg:f3}$.");
        }
    }
}
