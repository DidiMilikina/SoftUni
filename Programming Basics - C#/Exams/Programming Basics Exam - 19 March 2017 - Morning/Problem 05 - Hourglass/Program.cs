using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_05___Hourglass
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = 2 * n + 1;

            Console.WriteLine(new string('*',width));

            Console.Write(".");
            Console.Write("*");
            Console.Write(new string(' ', width - 4));
            Console.Write("*");
            Console.WriteLine(".");
            var points = 2;
            
            for (int i = 0; i < n - 2; i++)
            {
                var sharps = width - points * 2 - 2; 
                Console.Write(new string('.', points));
                Console.Write('*');
                Console.Write(new string('@',sharps));
                Console.Write('*');
                Console.WriteLine(new string('.', points));
                points += 1;
                
            }

            Console.Write(new string('.', n));
            Console.Write('*');
            Console.WriteLine(new string('.', n));

            points -= 1;
            for (int i = n - 3; i >= 0; i--)
            {
                var whiteSpaces = (width - 2 * points - 3) / 2;
                Console.Write(new string('.', points));
                Console.Write('*');
                Console.Write(new string(' ', whiteSpaces));
                Console.Write("@");
                Console.Write(new string(' ', whiteSpaces));
                Console.Write('*');
                Console.WriteLine(new string('.', points));
                points -= 1;
            }
            Console.Write('.');
            Console.Write('*');
            Console.Write(new string('@', width - 4));
            Console.Write('*');
            Console.WriteLine('.');
            Console.WriteLine(new string('*', width));
        }
    }
}
