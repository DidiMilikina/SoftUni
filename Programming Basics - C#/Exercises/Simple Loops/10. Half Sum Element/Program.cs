using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var greatestNumber = int.MinValue;
            var sum = 0;
            for (int i = 0; i < n; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;

                if (currentNumber > greatestNumber)
                {
                    greatestNumber = currentNumber;
                }
            }


            sum -= greatestNumber;
            if (sum == greatestNumber)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum - greatestNumber)}");
            }
        }
    }
}
