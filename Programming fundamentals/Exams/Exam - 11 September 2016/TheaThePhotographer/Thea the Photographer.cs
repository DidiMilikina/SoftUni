using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            string timeFormat = @"d\:hh\:mm\:ss";
            long amountPictures = long.Parse(Console.ReadLine());
            long amountTime = long.Parse(Console.ReadLine());
            long filterPercentage = long.Parse(Console.ReadLine());
            long timePerPicture = long.Parse(Console.ReadLine());

            var filterTime = amountPictures * amountTime;
            var usefulPictures = Math.Ceiling(amountPictures * (filterPercentage / 100.0));
            var uploading = usefulPictures * timePerPicture;
            var totalInSeconds = filterTime + uploading;

            TimeSpan time = TimeSpan.FromSeconds(totalInSeconds);
            Console.WriteLine(time.ToString(timeFormat));
        }
    }
}
