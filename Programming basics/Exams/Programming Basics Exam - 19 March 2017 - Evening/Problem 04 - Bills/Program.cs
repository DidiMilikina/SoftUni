using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04___Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            var months = double.Parse(Console.ReadLine());

            var electricityForAllMonths = 0.0;
            for (int i = 0; i < months; i++)
            {
                var current = double.Parse(Console.ReadLine());
                electricityForAllMonths += current;
            }
            var water = months * 20;
            var internet = months * 15;
            var other = (electricityForAllMonths + water + internet) * 1.2;
            var average = (electricityForAllMonths + water + internet + other) / months;
           
                Console.WriteLine($"Electricity: {electricityForAllMonths:F2} lv");
           Console.WriteLine($"Water: {water:F2} lv");
           Console.WriteLine($"Internet: {internet:F2} lv");
           Console.WriteLine($"Other: {other:F2} lv");
           Console.WriteLine($"Average: {average:F2} lv");
        }
    }
}
