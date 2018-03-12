using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Стоп
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var points = n + 1;
            var linesBegg = 2 * n + 1;
            var dashes = 2 * n - 1;

            Console.Write(new string('.', points));
            Console.Write(new string('_', linesBegg));
            Console.WriteLine(new string('.', points));

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('.', n + 1 - i));
                Console.Write("//");
                Console.Write(new string('_', dashes));
                Console.Write('\\');
                Console.Write('\\');
                Console.WriteLine(new string('.', n + 1 - i));
                dashes += 2;
            }

            Console.Write("//");
            Console.Write(new string('_', (dashes - 4)/ 2));
            Console.Write($"STOP!");
            Console.Write(new string('_', (dashes - 4)/ 2));
            Console.Write('\\');
            Console.WriteLine('\\');

            for (int i = n; i >= 1; i--)
            {
                Console.Write(new string('.', n - i));
                Console.Write("\\");
                Console.Write("\\");
                Console.Write(new string('_', 2 * n + i * 2 - 1));
                Console.Write("//");
                Console.WriteLine(new string('.', n - i));
            }
        }
    }
}
