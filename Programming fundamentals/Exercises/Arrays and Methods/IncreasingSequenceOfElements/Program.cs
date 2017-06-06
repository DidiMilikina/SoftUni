using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingSequenceOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            bool areaEqual = true;
            int previous = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] <= previous)
                {
                    areaEqual = false;
                    break;
                }

                previous = numbers[i];
            }
            if (areaEqual)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
