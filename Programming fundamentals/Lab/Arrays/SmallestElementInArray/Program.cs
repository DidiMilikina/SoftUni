using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int smallest = int.MaxValue;
            for (int i = 0; i < number.Length; i++)
            {
                var currentNumber = number[i];
                if(currentNumber < smallest)
                {
                    smallest = currentNumber;
                }
                
            }
            Console.WriteLine(smallest);
        }
    }
}
