using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_05___Parallelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var hight = 4 * n + 4;
            var width = 3 * n + 1;
            var numberOfWaves = n - 2;
            var pointsFirstLine = width - 2 - numberOfWaves;

            // first line
            Console.Write('+');
            Console.Write(new string('~', numberOfWaves));
            Console.Write('+');
            Console.WriteLine(new string('.', pointsFirstLine));
            
            // first part
            var numberOfLines = 2 * n + 1;
            var pointsBeggining = 0;
            for (int i= 0; i < numberOfLines; i++)
            {
                Console.Write('|');
                Console.Write(new string('.', pointsBeggining));
                Console.Write("\\");
                Console.Write(new string('~', numberOfWaves));
                Console.Write("\\");
                Console.WriteLine(new string('.', pointsFirstLine - 1));
                pointsBeggining += 1;
                pointsFirstLine -= 1;
            }

            // second part
            var pointsSecondPart = 0;
            var secondPart = hight - (numberOfLines + 2);
            var pointsEnd = 2 * n;
            for (int i = 0; i < secondPart; i++)
            {

                var points = width - (pointsBeggining + 6);
                Console.Write(new string('.', pointsSecondPart));
                Console.Write("\\");
                Console.Write(new string('.', pointsEnd));
                Console.Write('|');
                Console.Write(new string('~', numberOfWaves));
                Console.WriteLine('|');
                pointsSecondPart += 1;
                pointsEnd -= 1;
            }

            // end
            Console.Write(new string('.', pointsBeggining));
            Console.Write('+');
            Console.Write(new string('~', numberOfWaves));
            Console.WriteLine('+');
            
        }
    }
}