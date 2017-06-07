using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfNegativeElementsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numArray = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            bool containsNegative = numArray.Min() < 0;
            int counter = 0;

            for (int i = 0; i < numArray.Length; i++)
            {
                if (numArray[i] < 0)
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
