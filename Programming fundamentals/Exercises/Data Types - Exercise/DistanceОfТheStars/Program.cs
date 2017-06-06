using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceОfТheStars
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal kilometersOneLightYear = 9450000000000;
            decimal proximaCentery = kilometersOneLightYear * 4.22m;
            decimal center = kilometersOneLightYear * 26000;
            decimal milkyWay = kilometersOneLightYear * 100000;
            decimal edgeOfGalaxy = kilometersOneLightYear * 46500000000;

            Console.WriteLine($"{proximaCentery:e2}");
            Console.WriteLine($"{center:e2}");
            Console.WriteLine($"{milkyWay:e2}");
            Console.WriteLine($"{edgeOfGalaxy:e2}");
         }
    }
}
