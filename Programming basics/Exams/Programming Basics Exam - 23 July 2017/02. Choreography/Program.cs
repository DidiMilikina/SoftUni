using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            var steps = decimal.Parse(Console.ReadLine());
            var dancers = decimal.Parse(Console.ReadLine());
            var daysStuding = decimal.Parse(Console.ReadLine());

            var stepsDay = Math.Ceiling((steps / daysStuding) / steps * 100);
            var percentSteps = stepsDay / dancers;

            if (stepsDay <= 13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {percentSteps:f2}%.");
            }
            else
            {
                Console.WriteLine($"No, They will not succeed in that goal! Required {percentSteps:f2}% steps to be learned per day.");
            }
        }
    }
}
