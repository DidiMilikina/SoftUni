using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01.Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            var initialSpeed = double.Parse(Console.ReadLine());
            var firstTime = double.Parse(Console.ReadLine());
            var secondTime = double.Parse(Console.ReadLine());
            var thirdTime = double.Parse(Console.ReadLine());

            var distanceWithInitialSpeed = initialSpeed * firstTime / 60;  
            var distanceWithTenPercent = 0.1 * initialSpeed;
            var distanceSecondKm = distanceWithTenPercent + initialSpeed;
            var distance2 = secondTime / 60;
            var distanceWithRaiseAndTime = distanceSecondKm * distance2;  
            var distanceWithFivePercent = distanceSecondKm - (5 * distanceSecondKm / 100);
            var distance3 = thirdTime / 60;
            var distanceWithFivePercentResult = distanceWithFivePercent * distance3; 
            var total = distanceWithInitialSpeed + distanceWithRaiseAndTime + distanceWithFivePercentResult;
            Console.WriteLine("{0:f2}", total);
        }
    }
}
