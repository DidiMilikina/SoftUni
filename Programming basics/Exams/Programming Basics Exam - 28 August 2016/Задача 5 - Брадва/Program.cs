using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5___Брадва
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var width = 5 * n;
            
            // first 
            var lines = 3 * n;
            var linesMiddle = 0;
            var linesEnd = width - lines - linesMiddle - 2;

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('-', lines));
                Console.Write('*');
                Console.Write(new string('-', linesMiddle));
                Console.Write('*');
                Console.WriteLine(new string('-',linesEnd));
                linesMiddle += 1;
                linesEnd -= 1;
            }

            //second
            var starsSecondLoop = lines + 1;
            var lineSecondLoop = n / 2;
            var linesMiddleNeeded = linesMiddle - 1;
            var linesEndNeeded = linesEnd + 1;
            for (int i = 0; i < lineSecondLoop; i++)
            {
                Console.Write(new string('*', starsSecondLoop));
                Console.Write(new string('-', linesMiddleNeeded));
                Console.Write('*');
                Console.WriteLine(new string('-', linesEndNeeded));
                
                
            }

            //third 
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.Write(new string('-', lines));
                Console.Write('*');
                Console.Write(new string('-', linesMiddleNeeded));
                Console.Write('*');
                Console.WriteLine(new string('-', linesEndNeeded));
                lines -= 1;
                linesMiddleNeeded += 2;
                linesEndNeeded -= 1;
            }

            // fourth
            var linesEndFourth = lines;
            var stars = width - linesEndFourth - linesEndNeeded;
            Console.Write(new string('-', linesEndFourth));
            Console.Write(new string('*', stars));
            Console.WriteLine(new string('-', linesEndNeeded));

        }
    }
}
