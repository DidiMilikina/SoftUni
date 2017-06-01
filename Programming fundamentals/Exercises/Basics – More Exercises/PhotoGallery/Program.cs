using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoGallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int fileName = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double sizeInBytes = double.Parse(Console.ReadLine());
            int resolutionWidth = int.Parse(Console.ReadLine());
            int resolutionHeight = int.Parse(Console.ReadLine());

           
            Console.WriteLine($"Name: DSC_{fileName:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year} {hours}:{minutes:D2}");
            if (sizeInBytes <= 950)
            {
                Console.WriteLine($"Size: {sizeInBytes}B");
            }
            else if (sizeInBytes <= 500000)
            {
                double sizeKB = sizeInBytes / 1000;
                Console.WriteLine($"Size: {sizeKB}KB");
            }
            else
            {
                double sizeMB = sizeInBytes / 1000000;
                Console.WriteLine($"Size: {sizeMB:f1}MB");
            }
            

            if (resolutionHeight == resolutionWidth)
            {
                Console.WriteLine($"Resolution: {resolutionWidth}x{resolutionHeight} (square)");
            }
            else if(resolutionWidth > resolutionHeight)
            {
                Console.WriteLine($"Resolution: {resolutionWidth}x{resolutionHeight} (landscape)");
            }
            else
            {
                Console.WriteLine($"Resolution: {resolutionWidth}x{resolutionHeight} (portrait)");
            }
        }
    }
}
