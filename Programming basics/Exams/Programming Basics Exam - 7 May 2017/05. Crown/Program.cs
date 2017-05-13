using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Crown
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = 2 * n + 1;
            var height = n / 2 + 4;

            var firstEmpties = n - 2;
            Console.Write('@');
            Console.Write(new string(' ', firstEmpties));
            Console.Write('@');
            Console.Write(new string(' ', firstEmpties));
            Console.WriteLine('@');

            Console.Write("**");
            Console.Write(new string(' ', n/2 + 1));
            Console.Write('*');
            Console.Write(new string(' ', n/2 + 1));
            Console.WriteLine("**");

            var secondEmpties = n - 5;
            var pointsMiddle = 1;
            for (int i = 1; i <= n / 2 - 1; i++)
            {
                Console.Write('*');
                Console.Write(new string('.', i));
                Console.Write('*');
                Console.Write(new string(' ', secondEmpties));
                Console.Write('*');
                Console.Write(new string('.', pointsMiddle));
                Console.Write('*');
                Console.Write(new string(' ', secondEmpties));
                Console.Write('*');
                Console.Write(new string('.', i));
                Console.WriteLine('*');
                pointsMiddle += 2;
                secondEmpties -= 2;
            }

            var stars = width - 2 * pointsMiddle - 3;

            Console.Write('*');
            Console.Write(new string('.', pointsMiddle + 1));
            Console.Write(new string('*', ));
            Console.Write('.');
            Console.Write(new string('*', ));
            Console.Write(new string('.', pointsMiddle + 1));
            Console.WriteLine('*');
                

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(new string('*', width));
            }
        }
    }
}
