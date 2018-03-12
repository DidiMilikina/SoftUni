using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
           
            #region first line
            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', 2 * n));
            #endregion

            #region middle
            var noseIndex = (n - 1) / 2 - 1;

            for (int row = 0; row < n - 2; row++)
            {
                if(row != noseIndex)
                {
                    Console.Write('*');
                    Console.Write(new string('/', n * 2 - 2));
                    Console.Write('*');
                    Console.Write(new string(' ', n));
                    Console.Write('*');
                    Console.Write(new string('/', n * 2 - 2));
                    Console.WriteLine('*');
                }
                else
                {
                    Console.Write('*');
                    Console.Write(new string('/', n * 2 - 2));
                    Console.Write('*');
                    Console.Write(new string('|', n));
                    Console.Write('*');
                    Console.Write(new string('/', n * 2 - 2));
                    Console.WriteLine('*');
                }
            }
            #endregion


            #region last region
            Console.Write(new string('*', n * 2));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', n * 2));
            #endregion
        }
    }
}
