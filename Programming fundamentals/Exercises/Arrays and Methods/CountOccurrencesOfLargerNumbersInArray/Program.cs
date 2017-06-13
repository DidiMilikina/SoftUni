using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOccurrencesOfLargerNumbersInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();
            double secondNum = double.Parse(Console.ReadLine());

            double counter = 0;
            foreach (var num in numbers)
            {
                if (num > secondNum)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}