using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_05___SoftUni_Logo
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var height = 4 * n - 2;
            var width = 12 * n - 5;

            Console.WriteLine();
            for (int count = 0; count < 2 * n; count++)
            {
                var countOfSharps = count * 6 + 1;
                var countOfPoints = (width - countOfSharps) / 2;
                Console.Write(new string('.', countOfPoints));
                Console.Write(new string('#', countOfSharps));
                Console.Write(new string('.', countOfPoints));
                Console.WriteLine();
            }
            var middle = height - 2 * n - 1;
            var minimalSharps = n * 6 + 1;
            for (int i = 2 * n - 2; i >= 2 * n - 1- middle; i--)
            {
                var countOfSharps = i * 6 + 1;
                if (countOfSharps < minimalSharps)
                {
                    countOfSharps = minimalSharps;
                }

                var countOfPoints = (width - countOfSharps) / 2;
                Console.Write('|');
                Console.Write(new string('.', countOfPoints - 1));
                Console.Write(new string('#', countOfSharps));
                Console.Write(new string('.', countOfPoints));
                Console.WriteLine();
            }

            var countOfEndPoints = (width - minimalSharps) / 2;
            Console.Write('@');
            Console.Write(new string('.', countOfEndPoints - 1));
            Console.Write(new string('#', minimalSharps));
            Console.Write(new string('.', countOfEndPoints));
            Console.WriteLine();

        }

    }
}
