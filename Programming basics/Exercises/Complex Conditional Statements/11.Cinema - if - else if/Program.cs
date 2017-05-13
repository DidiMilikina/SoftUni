using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema___if___else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            var movie = Console.ReadLine().ToLower();
            var rows = double.Parse(Console.ReadLine());
            var columns = double.Parse(Console.ReadLine());
            var price = 0.0;
            if (movie == "premiere")
            {
                var count = rows * columns;
                price = 12.0; Console.WriteLine("{0:f2}", count * price);
            }
            else if (movie == "normal")
            {
                var count = rows * columns;
                price = 7.50; Console.WriteLine("{0:f2}", count * price);
            }
            else if (movie == "discount")
            {
                var count = rows * columns;
                price = 5.00; Console.WriteLine("{0:f2}", count * price);
            }
        }
    }
}
