using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Фирма
{
    class Program
    {
        static void Main(string[] args)
        {
            var neededHours = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var overtimeWorkers = int.Parse(Console.ReadLine());

            var realDays = days * 0.9;
            var workingHours = Math.Floor(realDays * 8);
            var overtime = overtimeWorkers * 2 * days;
            var totalWorkingHours = workingHours + overtime;

            if (totalWorkingHours >= neededHours)
            {
                var leftHours = totalWorkingHours - neededHours;
                Console.WriteLine($"Yes!{leftHours} hours left.");
            }
            else
            {
                var insufficientHours = neededHours - totalWorkingHours;
                Console.WriteLine($"Not enough time!{insufficientHours} hours needed.");
            }
        }
    }
}

