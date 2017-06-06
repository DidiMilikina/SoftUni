using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NthDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());

            Console.WriteLine(FindNthDigit(number, index));
        }

        static long FindNthDigit(long number, int index)
        {
            int num = 1;

            while (number > 1)
            {
                if(index == num)
                {
                    number %= 10;
                    break;
                }
                else
                {
                    number /= 10;
                }
                num++;
            }
            return number;
        }
    }
}
