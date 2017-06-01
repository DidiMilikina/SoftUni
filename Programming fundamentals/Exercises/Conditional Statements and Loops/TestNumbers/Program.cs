using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());

            int counter = 0;
            int sum = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    counter++;
                    sum += 3 * (i * j);

                    if (sum >= maxSum)
                    {
                        break;
                    }

                }

                if (sum >= maxSum)
                {
                    break;
                }
            }

            if (sum >= maxSum)
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {sum} >= {maxSum}");
            }

            else
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}



