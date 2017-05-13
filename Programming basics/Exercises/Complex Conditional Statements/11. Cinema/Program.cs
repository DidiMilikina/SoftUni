using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeProjection = Console.ReadLine();
            var rows = int.Parse(Console.ReadLine());
            var columns = int.Parse(Console.ReadLine());
            var seats = rows * columns;
            var price = 0.0;

            switch (typeProjection)
            {
                case "Premiere": price = 12; break;
                case "Normal": price = 7.5; break;
                case "Discount": price = 5; break;
            }

            double total = seats * price;
            Console.WriteLine("{0:f2} leva", total);
        }
    }
}
