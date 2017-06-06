using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfGivenElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers.Length > 0)
                {
                    counter++;
                    Console.WriteLine(counter);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
