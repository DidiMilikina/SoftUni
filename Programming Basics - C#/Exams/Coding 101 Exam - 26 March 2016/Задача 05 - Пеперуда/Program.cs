using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_05___Пеперуда
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = 2 * n - 1;
            var hight = 2 * (n - 2) + 1;
            var leftRightPart = n - 1;

            var stars = n - 2;
            for (int i = 0; i < n - 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(new string('*', stars));
                    Console.Write('\\');
                    Console.Write(" ");
                    Console.Write('/');
                    Console.WriteLine(new string('*', stars));
                }
                else
                {
                    Console.Write(new string('-', stars));
                    Console.Write('\\');
                    Console.Write(" ");
                    Console.Write('/');
                    Console.WriteLine(new string('-', stars));
                }
            }

            Console.Write(new string(' ', n - 2 + 1));
            Console.Write('@');
            Console.WriteLine(new string(' ', n - 2 + 1));

            for (int i = 0; i < n - 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(new string('*', stars));
                    Console.Write('/');
                    Console.Write(" ");
                    Console.Write('\\');
                    Console.WriteLine(new string('*', stars));
                }
                else
                {
                    Console.Write(new string('-', stars));
                    Console.Write('/');
                    Console.Write(" ");
                    Console.Write('\\');
                    Console.WriteLine(new string('-', stars));
                }
            }
        }
    }
}
