using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            var area = r * r * Math.PI;
            Console.WriteLine(area);
            Console.WriteLine("Perimeter = " + 2 * Math.PI * r);
        }
    }
}
