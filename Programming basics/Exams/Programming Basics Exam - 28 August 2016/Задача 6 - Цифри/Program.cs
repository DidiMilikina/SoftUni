using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6___Цифри
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var firstN = number / 100;
            var secondN = number / 10 % 10;
            var thirdN = number % 10;
            var rows = firstN + secondN;
            var cols = firstN + thirdN;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (number % 5 == 0)
                    {
                        number = number - firstN;
                    }
                    else if (number % 3 == 0)
                    {
                        number = number - secondN;
                    }
                    else
                    {
                        number += thirdN;
                    }
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
