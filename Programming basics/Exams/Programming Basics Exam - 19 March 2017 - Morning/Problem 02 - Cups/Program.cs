using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02___Cups
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberCups = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var workDays = int.Parse(Console.ReadLine());

            var hours = ((workers * workDays) * 8) / 5;
            if(numberCups >= hours)
            {var losses = (numberCups - hours) * 4.2;
                Console.WriteLine($"Losses: {losses:f2}");
            }
            else
            {
                var extraMoney = (hours - numberCups) * 4.2;
                Console.WriteLine($"{extraMoney:f2} extra money");
            }
        }
    }
}
