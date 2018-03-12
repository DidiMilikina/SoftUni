using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Дневна_печалба
{
    class Program
    {
        static void Main(string[] args)
        {
            var workDaysInMonth = double.Parse(Console.ReadLine());
            var earnedMoney = double.Parse(Console.ReadLine());
            var dollars = double.Parse(Console.ReadLine());
            

            var monthSalaryInDollars = workDaysInMonth * earnedMoney;
            var revenue = monthSalaryInDollars * 12 + monthSalaryInDollars * 2.5;
            var tribute = revenue * (25 / 100.0);
            var netIncomeInDollars = revenue - tribute;
            var netIncomeInLeva = netIncomeInDollars * dollars;
            var averageProfitPerDayInLeva = netIncomeInLeva / 365;
            Console.WriteLine($"{averageProfitPerDayInLeva:f2}");


        }
    }
}
