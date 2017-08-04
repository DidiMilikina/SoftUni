using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wormhole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var counter = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != 0)
                {
                    var lastIndex = i;
                    i = numbers[i];
                    numbers[lastIndex] = 0;
                }
                counter++;
            }
            Console.WriteLine(counter);
        }
    }
}
