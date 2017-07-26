using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Dance_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());

            var room = (l * 100) * (w * 100);
            var wardrobe = a * a * 10000;
            var bench = room / 10;
            var space = room - wardrobe - bench;
            var numberDancers = space / (40 + 7000);

            Console.WriteLine(Math.Floor(numberDancers));
        }
    }
}
