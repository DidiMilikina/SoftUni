using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var totalRow = 3 * n;

            var countOfSpaces = 0;
            for (int countOfPoints = 1; countOfPoints <= n; countOfPoints++)
            {
                var countOfDots = (totalRow - 2 - countOfSpaces) / 2;
                Console.Write(new string('.', countOfDots));
                Console.Write("/");
                Console.Write(new string(' ', countOfSpaces));
                Console.Write('\\');
                Console.Write(new string('.', countOfDots));
                Console.WriteLine();
                countOfSpaces += 2;
            }

            Console.Write(new string('.', n / 2));
            Console.Write(new string('*', totalRow - n));
            Console.Write(new string('.', n / 2));
            Console.WriteLine();

            for (int i = 1; i <= n * 2; i++)
            {

                Console.Write(new string('.', n / 2));
                Console.Write('|');
                Console.Write(new string('\\', totalRow - n - 2));
                Console.Write('|');
                Console.Write(new string('.', n / 2));
                Console.WriteLine();
            }

            var dots = n / 2;
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('.', dots));
                Console.Write('/');
                Console.Write(new string('*', totalRow - 2 * dots - 2));
                Console.Write('\\');
                Console.Write(new string('.', dots));
                Console.WriteLine();
                dots--;
            }





        }
    }
}
