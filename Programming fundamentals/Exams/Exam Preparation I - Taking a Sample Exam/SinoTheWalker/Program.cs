using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeFormat = @"HH\:mm\:ss";
            var leavingTime = 
                DateTime.ParseExact(Console.ReadLine(), timeFormat, CultureInfo.InvariantCulture);

            var numberOfSteps = decimal.Parse(Console.ReadLine());
            var timeInSecondsPerStep = decimal.Parse(Console.ReadLine());

            var secondsPerDay = 60 * 60 * 24;
            var totalSecondsNeeded = (int)(numberOfSteps * timeInSecondsPerStep % secondsPerDay);
            var arrivalTime = leavingTime.AddSeconds(totalSecondsNeeded);

            Console.WriteLine($"Time Arrival: {arrivalTime.ToString(timeFormat)}");
        }
    }
}