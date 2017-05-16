using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Refactor_Volume
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
           
            var volumeOfPyramid = (width * length * height) / 3;

            Console.Write("Length: ");
            Console.Write("Width: ");
            Console.Write("Height: ");
            Console.WriteLine($"Pyramid Volume: {volumeOfPyramid:f2}");
        }
    }
}
