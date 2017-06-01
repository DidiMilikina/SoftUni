using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int start = Math.Min(num1, num2);
            int end = Math.Max(num2, num1);

            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
