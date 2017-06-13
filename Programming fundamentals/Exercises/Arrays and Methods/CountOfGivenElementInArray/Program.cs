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
                .Split()
                .Select(int.Parse)
                .ToArray();
            int secondNum = int.Parse(Console.ReadLine());

            int counter = 0;
            foreach (var num in numbers)
            {
                if (num == secondNum)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
