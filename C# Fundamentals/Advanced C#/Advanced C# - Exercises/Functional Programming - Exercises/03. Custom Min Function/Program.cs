using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            Func<int[], int> minFunc = GetMin;
            var minNumber = minFunc(input);
            Console.WriteLine(minNumber);
        }

        private static int GetMin(int[] input)
        {
            var currentMinlValue = int.MaxValue;

            foreach (var number in input)
            {
                if (number < currentMinlValue)
                {
                    currentMinlValue = number;
                }
            }

            return currentMinlValue;
        }
    }
}
