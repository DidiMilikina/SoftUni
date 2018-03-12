using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = 5 * n;
            var height = 3 * n + 2;

            Console.Write(new string('.',n));
            Console.Write(new string('*', width - 2 * n));
            Console.WriteLine(new string('.', n));

            for (int j = n -1; j > 0; j--)
            {
                
                Console.Write(new string('.', j));
                Console.Write("*");
                Console.Write(new string('.', width - 2 - 2 * j));
                Console.Write("*");
                Console.WriteLine(new string('.', j)); 
            }

            Console.WriteLine(new string('*', width));
            
            for (int i = 1; i < 2 * n + 1; i++)
            {
                Console.Write(new string('.', i));
                Console.Write("*");
                Console.Write(new string('.', width - 2 - 2 * i));
                Console.Write("*");
                Console.WriteLine(new string('.', i));
                
            }

            var pointsBegg = 2 * n + 1;
            Console.Write(new string('.', pointsBegg));
            Console.Write(new string('*', (pointsBegg / 2) - 2));
            Console.WriteLine(new string('.', pointsBegg));
        }
    }
}
