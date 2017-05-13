using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var currentNumber = 1;
            var row = 1;
            while (currentNumber <= n)
            {
                for (int i = 0; i < row; i++)
                {
                    if (currentNumber > n)
                    {
                        break;
                    }
                    Console.Write(currentNumber + " ");
                    currentNumber++;
                }
                row++;
                Console.WriteLine();
            }
        }
    }
}
