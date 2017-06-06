using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSequenceOfElementsInArray
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

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] != numbers[i + 1])
                {
                    areaEqual = false;
                    break;
                }
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
