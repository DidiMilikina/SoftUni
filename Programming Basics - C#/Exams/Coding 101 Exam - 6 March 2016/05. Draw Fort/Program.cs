using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Draw_Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = 2 * n;
            var columnsSize = n / 2;
            var lines = 2 * n - 2 * columnsSize - 4;

            //first line
            Console.Write("/");
            Console.Write(new string('^', columnsSize));
            Console.Write('\\');
            Console.Write(new string('_', lines));
            Console.Write("/");
            Console.Write(new string('^', columnsSize));
            Console.WriteLine('\\');

            for (int i = 1; i <= n - 3; i++)
            {
                Console.Write('|');
                Console.Write(new string(' ', 2 * n - 2));
                Console.WriteLine('|');
            }

            Console.Write('|');
            Console.Write(new string(' ', columnsSize + 1));
            Console.Write(new string('_', lines));
            Console.Write(new string(' ', columnsSize + 1));
            Console.WriteLine('|');

            //last line
            Console.Write("\\");
            Console.Write(new string('_', columnsSize));
            Console.Write("/");
            Console.Write(new string(' ', lines));
            Console.Write('\\');
            Console.Write(new string('_', columnsSize));
            Console.WriteLine('/');
        }
    }
}
