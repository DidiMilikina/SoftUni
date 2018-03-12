using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_05.Christmas_Hat
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var widthColumns = 4 * n + 1;
            var hightColumns = 2 * n + 5;
            var countOfPoints = (widthColumns - 3) / 2;


            #region first line
            Console.Write(new string('.', countOfPoints));
            Console.Write('/');
            Console.Write('|');
            Console.Write('\\');
            Console.Write(new string('.', countOfPoints));
            Console.WriteLine();
            #endregion


            #region second line
            Console.Write(new string('.', countOfPoints));
            Console.Write('\\');
            Console.Write('|');
            Console.Write('/');
            Console.Write(new string('.', countOfPoints));
            Console.WriteLine();
            #endregion

            #region middle dash

            for (int count = 0; count < 2 * n; count++)
            {
                var countOfDashes = count;
                var countOfDots = (widthColumns - 3 - countOfDashes * 2) / 2;
                Console.Write(new string('.', countOfDots));
                Console.Write("*");
                Console.Write(new string('-', countOfDashes));
                Console.Write("*");
                Console.Write(new string('-', countOfDashes));
                Console.Write("*");
                Console.Write(new string('.', countOfDots));
                Console.WriteLine();
            }
            #endregion

            #region bottom
            Console.Write(new string('*', widthColumns));
            Console.WriteLine();
            for (int i = 1; i <= widthColumns / 2; i++)
            {
                Console.Write("*.");
            }
            Console.WriteLine("*");
            Console.Write(new string('*', widthColumns));
            Console.WriteLine();
            #endregion
        }
    }
}
