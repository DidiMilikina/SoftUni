using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            var mackerel = double.Parse(Console.ReadLine());
            var sprat = double.Parse(Console.ReadLine());
            var beltedBonito = double.Parse(Console.ReadLine());
            var scad = double.Parse(Console.ReadLine());
            var clams = int.Parse(Console.ReadLine());

            var priceOfBeltedBonito = mackerel + mackerel * 0.6;
            var priceOfScad = sprat + sprat * 0.8;
            var priceOfClams = 7.5;
            var total = priceOfBeltedBonito * beltedBonito + priceOfScad * scad + priceOfClams * clams;
            Console.WriteLine("{0:f2}", total);

        }
    }
}
