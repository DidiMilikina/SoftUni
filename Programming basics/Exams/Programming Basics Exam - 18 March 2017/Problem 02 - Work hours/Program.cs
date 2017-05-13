using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02___Work_hours
{
    class Program
    {
        static void Main(string[] args)
        {
            var neededHours = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var workDays = int.Parse(Console.ReadLine());

            
            var hours = (workers * workDays) * 8;
            if(neededHours <= hours)
            {
                var hoursLeft = hours - neededHours;
                Console.WriteLine($"{hoursLeft} hours left");
            }
            else
            { var penalties = (neededHours - hours) * workDays;
                Console.WriteLine($"{neededHours - hours} overtime");
                Console.WriteLine($"Penalties: {penalties}");
            }
           
        }
    }
}
