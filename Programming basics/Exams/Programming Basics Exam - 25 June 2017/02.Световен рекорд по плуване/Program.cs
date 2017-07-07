using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Световен_рекорд_по_плуване
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSecPerMeter = double.Parse(Console.ReadLine());

            double shoudSwim = distanceInMeters * timeInSecPerMeter;
            double addedTime = Math.Floor(distanceInMeters / 15) * 12.5;
            double totalTime = shoudSwim + addedTime;

            if (recordInSeconds > totalTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                double neededTime = totalTime - recordInSeconds;
                Console.WriteLine($"No, he failed! He was {neededTime:f2} seconds slower.");
            }
        }
    }
}