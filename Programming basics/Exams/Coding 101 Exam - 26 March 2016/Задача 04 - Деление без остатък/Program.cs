using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Деление_без_остатък
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var firstDividedNumber = 0.00;
            var secondDividedNumber = 0.00;
            var thirdDividedNumber = 0.00;
            for (int i = 0; i < n; i++)
            {
                var currentNumber = double.Parse(Console.ReadLine());
                if (currentNumber % 2 == 0)
                {
                    firstDividedNumber++;
                }
                if (currentNumber % 3 == 0)
                {

                    secondDividedNumber++;
                }
                if (currentNumber % 4 == 0)
                {
                    thirdDividedNumber++;
                }
            }
            var p1 = (firstDividedNumber / n) * 100;
            var p2 = (secondDividedNumber / n) * 100;
            var p3 = (thirdDividedNumber / n) * 100;
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");

        }
    }
}