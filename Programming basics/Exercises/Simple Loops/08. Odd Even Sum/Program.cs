using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var oddSum = 0.0;
            var evenSum = 0.0;
            for (int i = 0; i < n; i++)
            {
                var currentNumber = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += currentNumber;
                }
                else
                {
                    oddSum += currentNumber;
                }

            }
            if (oddSum == evenSum)
            {
                Console.WriteLine($"Yes, sum {oddSum}");
            }
            else
            {
                var diff = Math.Abs(oddSum - evenSum);
                Console.WriteLine($"No, diff = {diff}");

            }
        }
    }
}