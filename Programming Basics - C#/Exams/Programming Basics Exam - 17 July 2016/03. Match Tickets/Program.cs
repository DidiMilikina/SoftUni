using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            var numberOfPeopleInGroup = int.Parse(Console.ReadLine());
            var transportPrice = 0.0;

            if (numberOfPeopleInGroup >= 1 && numberOfPeopleInGroup <= 4)
            {
                transportPrice = budget * 0.75;
            }
            else if (numberOfPeopleInGroup >= 5 && numberOfPeopleInGroup <= 9)
            {
                transportPrice = budget * 0.6;
            }
            else if (numberOfPeopleInGroup >= 10 && numberOfPeopleInGroup <= 24)
            {
                transportPrice = budget * 0.5;
            }
            else if (numberOfPeopleInGroup >= 25 && numberOfPeopleInGroup <= 49)
            {
                transportPrice = budget * 0.4;
            }
            else
            {
                transportPrice = budget * 0.25;
            }

            var moneyLeft = budget - transportPrice;

            var moneyForTickets = 0.0;

            if (category == "VIP")
            {
                var moneyForVipTicket = 499.99;
                moneyForTickets = numberOfPeopleInGroup * moneyForVipTicket;
            }
            else
            {
                var moneyForNormalTickets = 249.99;
                moneyForTickets = numberOfPeopleInGroup * moneyForNormalTickets;
            }

            var left = Math.Abs(moneyLeft - moneyForTickets);
            if (moneyForTickets <= moneyLeft)
            {
                Console.WriteLine("Yes! You have {0:F2} leva left.", left);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:F2} leva.", left);
            }
        }
    }
}
