using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var sum = 0;
            do
            {
                var lastDigit = number % 10;
                sum += lastDigit;
                number /= 10;
            } while (number > 0);
            Console.WriteLine($"Sum of digits: {sum}");
        }
    }
}
