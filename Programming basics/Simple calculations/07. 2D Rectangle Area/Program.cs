using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var width = Math.Abs(x1 - x2);
            var height = Math.Abs(y1 - y2);

            var area = width * height;
            Console.WriteLine("Area = {0}", width * height);

            Console.WriteLine("Perimeter = {0}", 2 * (width + height));



        }
    }
}
