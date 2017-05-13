using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            var distance = double.Parse(Console.ReadLine());
            var timeOfDay = Console.ReadLine();
            var taxiInitialPrice = 0.7;
            var taxiDayPrice = 0.79;
            var taxiNightPrice = 0.9;
            var bus = 0.09;
            var train = 0.06;

            if (distance >= 100)
            {
                //Train
                Console.WriteLine(distance * train);
            }
            else if (distance >= 20)
            {
                //Bus
                Console.WriteLine(distance * bus);
            }
            else
            {
                //Taxi
                if (timeOfDay == "day")
                {
                    Console.WriteLine(taxiInitialPrice + distance * taxiDayPrice);
                }
                else if (timeOfDay == "night")
                {
                    Console.WriteLine(taxiInitialPrice + distance * taxiNightPrice);
                }
            }
        }
    }
}

