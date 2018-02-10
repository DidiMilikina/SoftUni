using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snowflake
{
    class Snowflake
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int width = 2 * number + 3;
            int length = 2 * number + 1;

            int pointsMiddle = number;
            for (int i = 0; i < number - 1; i++)
            {
                Console.Write(new string('.', i));
                Console.Write('*');
                Console.Write(new string('.', pointsMiddle));
                Console.Write('*');
                Console.Write(new string('.', pointsMiddle));
                Console.Write('*');
                Console.WriteLine(new string('.', i));
                pointsMiddle--;
            }

            int pointsSecond = number - 1;
            Console.Write(new string('.', pointsSecond));
            Console.Write(new string('*', 5));
            Console.WriteLine(new string('.', pointsSecond));

            Console.WriteLine(new string('*', width));

            Console.Write(new string('.', pointsSecond));
            Console.Write(new string('*', 5));
            Console.WriteLine(new string('.', pointsSecond));

            int pointsEnd = number - 2;
            int pointsMiddleEnd = 2;
            for (int i = number - 1; i > 0; i--)
            {
                Console.Write(new string('.', pointsEnd));
                Console.Write('*');
                Console.Write(new string('.', pointsMiddleEnd));
                Console.Write('*');
                Console.Write(new string('.', pointsMiddleEnd));
                Console.Write('*');
                Console.WriteLine(new string('.', pointsEnd));
                pointsEnd--;
                pointsMiddleEnd++;
            }
        }
    }
}
