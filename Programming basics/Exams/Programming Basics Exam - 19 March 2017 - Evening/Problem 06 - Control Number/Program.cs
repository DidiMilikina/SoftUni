using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_06___Control_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var controlNumber = int.Parse(Console.ReadLine());
            var sum = 0;
            var counter = 0;

            for (int firstNumber = 1; firstNumber <= n; firstNumber++)
            {
                for (int secondNumber = m; secondNumber >= 1; secondNumber--)
                {

                    sum += firstNumber * 2 + secondNumber * 3;
                    counter++;
                    if (sum >= controlNumber)
                    {

                        break;
                    }
                }

                if (sum >= controlNumber)
                {

                    break;
                }

            }

            if (sum >= controlNumber)
            {
                Console.WriteLine($"{counter} moves");
                Console.WriteLine($"Score: {sum} >= {controlNumber}");
            }
            else
            {
                Console.WriteLine($"{counter} moves");
            }


        }
    }
}