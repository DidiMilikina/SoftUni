using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double sum = (width * height) / 1000000;
            Console.WriteLine($"{width}x{height} => { Math.Round(sum, 1)}MP");
        }
    }
}
