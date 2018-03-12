using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var countOfNumberInFirstRange = 0.0;
            var countOfNumbersInSecondRange = 0.0;
            var countOfNumbersInThirdRange = 0.0;
            var countOfNumbersInFourthRange = 0.0;
            var countOfNumbersInFifthRange = 0.0;
            for (int i = 0; i < n; i++)
            {
                var currenNumber = double.Parse(Console.ReadLine());

                if (currenNumber < 200)
                {
                    countOfNumberInFirstRange++;
                }
                else if (currenNumber >= 200 && currenNumber <= 399)
                {
                    countOfNumbersInSecondRange++;
                }
                else if (currenNumber >= 400 && currenNumber <= 599)
                {
                    countOfNumbersInThirdRange++;
                }
                else if (currenNumber >= 600 && currenNumber <= 799)
                {
                    countOfNumbersInFourthRange++;
                }
                else
                {
                    countOfNumbersInFifthRange++;
                }
            }

            var p1 = countOfNumberInFirstRange / n * 100;
            var p2 = countOfNumbersInSecondRange / n * 100;
            var p3 = countOfNumbersInThirdRange / n * 100;
            var p4 = countOfNumbersInFourthRange / n * 100;
            var p5 = countOfNumbersInFifthRange / n * 100;
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");

        }
    }
}