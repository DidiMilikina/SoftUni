using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Cup
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int width = number * 5;

            int dotsFirst = number;
            int dotsSecond = number;
            int sharpsFirst = number * 3;
            for (int i = 0; i < number / 2; i++)
            {
                Console.Write(new string('.', dotsFirst));
                Console.Write(new string('#', sharpsFirst));
                Console.WriteLine(new string('.', dotsSecond));
                dotsFirst++;
                dotsSecond++;
                sharpsFirst -= 2;
            }

            int points = width - dotsFirst - dotsSecond - 2;
            for (int i = 0; i < number / 2 + 1; i++)
            {
                Console.Write(new string('.', dotsFirst));
                Console.Write("#");
                Console.Write(new string('.', points));
                Console.Write("#");
                Console.WriteLine(new string('.', dotsSecond));
                dotsFirst++;
                dotsSecond++;
                points -= 2;
                sharpsFirst -= 2;
            }

            int pointsSecond = number;
            int pointsLoop = width - number;
            Console.Write(new string('.', pointsLoop / 2));
            Console.Write(new string('#', pointsSecond));
            Console.WriteLine(new string('.', pointsLoop / 2));

            for (int i = 0; i < number / 2; i++)
            {
                Console.Write(new string('.', pointsLoop / 2 - 2));
                Console.Write(new string('#', pointsSecond + 4));
                Console.WriteLine(new string('.', pointsLoop / 2 - 2));
            }

            String dance = "D^A^N^C^E^";
            int point = width - 10;
            Console.Write(new string('.', point / 2));
            Console.Write(dance);
            Console.WriteLine(new string('.', point / 2));

            for (int i = 0; i < number / 2 + 1; i++)
            {
                Console.Write(new string('.', pointsLoop / 2 - 2));
                Console.Write(new string('#', pointsSecond + 4));
                Console.WriteLine(new string('.', pointsLoop / 2 - 2));
            }
        }
    }
}
