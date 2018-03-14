using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Recursive_Fibonacci
{
    class Program
    {
        private static long[] fibbonacciNumbers;

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            fibbonacciNumbers = new long[number];

            long nhtFibbonacci = GetFibbonacci(number);
            Console.WriteLine(nhtFibbonacci);
        }

        private static long GetFibbonacci(int num)
        {
            if (num <= 2)
            {
                fibbonacciNumbers[num - 1] = 1;
                return 1;
            }
            else if (fibbonacciNumbers[num - 1] != 0)
            {
                return fibbonacciNumbers[num - 1];
            }

            return fibbonacciNumbers[num - 1] = GetFibbonacci(num - 1) + GetFibbonacci(num - 2);
        }
    }
}
