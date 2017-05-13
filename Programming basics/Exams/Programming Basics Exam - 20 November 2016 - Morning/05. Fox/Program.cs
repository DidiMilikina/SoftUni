using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var totalRow = 2 * n + 3;

            for (int countOfStars = 1; countOfStars <= n; countOfStars++)
            {
                var countOfDashes = totalRow - 2 * countOfStars - 2;
                Console.Write(new string('*', countOfStars));
                Console.Write("\\");
                Console.Write(new string('-', countOfDashes));
                Console.Write("/");
                Console.WriteLine(new string('*', countOfStars));
            }

            var countOfRowsInMiddle = n / 3;
            var starsInEnd = (n - 1) / 2;

            for (int row = 0; row < countOfRowsInMiddle; row++)
            {
                var starsInMiddle = totalRow - 2 * starsInEnd - 4;
                Console.Write('|');
                Console.Write(new string('*', starsInEnd));
                Console.Write('\\');
                Console.Write(new string('*', starsInMiddle));
                Console.Write('/');
                Console.Write(new string('*', starsInEnd));
                Console.WriteLine('|');
                starsInEnd++;
            }

            for (int countOfStars = 1; countOfStars <= n; countOfStars++)
            {
                var countOfDashes = totalRow - 2 * countOfStars - 2;
                Console.Write(new string('-', countOfStars));
                Console.Write("\\");
                Console.Write(new string('*', countOfDashes));
                Console.Write("/");
                Console.WriteLine(new string('-', countOfStars));
            }
        }
    }
}
