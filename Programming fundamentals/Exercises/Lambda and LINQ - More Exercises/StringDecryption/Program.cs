using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringDecryption
{
    class Program
    {
        static void Main(string[] args)
        {
            var twoNums = Console.ReadLine()
                .Split(' ')
                .ToArray();
            var numberToSkip = int.Parse(twoNums[0]);
            var numberToTake = int.Parse(twoNums[1]);

            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            numbers = numbers
                .Where(n => n >= 65 && n <= 90)
                .Skip(numberToSkip)
                .Take(numberToTake)
                .ToArray();

            foreach (var numToChar in numbers)
            {
                Console.Write((char) numToChar);
            }
            Console.WriteLine();
        }
    }
}
