using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_04___Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            var move = int.Parse(Console.ReadLine());
            var totalNumbers = 0.0;

            var numberInFirst = 0.0;
            var numberInSecond = 0.0;
            var numberInThird = 0.0;
            var numberInFourth = 0.0;
            var numberInFifth = 0.0;
            var invalidNumber = 0.0;

            for (int i = 0; i < move; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number >= 0 && number <= 9)
                {
                    totalNumbers += 0.2 * number;
                    numberInFirst++;
                }
                else if (number >= 10 && number <= 19)
                {
                    totalNumbers += 0.3 * number;
                    numberInSecond++;
                }
                else if (number >= 20 && number <= 29)
                {
                    totalNumbers += 0.4 * number;
                    numberInThird++;
                }
                else if (number >= 30 && number <= 39)
                {
                    totalNumbers += 50;
                    numberInFourth++;
                }
                else if (number >= 40 && number <= 50)
                {
                    totalNumbers += 100;
                    numberInFifth++;
                }
                else
                {
                    totalNumbers /= 2;
                    invalidNumber++;
                }
            }

            Console.WriteLine($"{totalNumbers:F2}");
            Console.WriteLine($"From 0 to 9: {numberInFirst / move * 100.0:F2}%");
            Console.WriteLine($"From 10 to 19: {numberInSecond / move * 100.0:F2}%");
            Console.WriteLine($"From 20 to 29: {numberInThird / move * 100.0:F2}%");
            Console.WriteLine($"From 30 to 39: {numberInFourth / move * 100.0:F2}%");
            Console.WriteLine($"From 40 to 50: {numberInFifth / move * 100.0:F2}%");
            Console.WriteLine($"Invalid numbers: {invalidNumber / move * 100.0:F2}%");

        }
    }
}
