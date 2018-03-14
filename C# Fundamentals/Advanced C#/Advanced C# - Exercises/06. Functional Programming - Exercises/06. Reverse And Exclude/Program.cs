using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse);
            int divisor = int.Parse(Console.ReadLine());

            Func<int, bool> filter = n => n % divisor != 0;

            var reversedNumbers = input.Reverse().Where(filter);
            Console.WriteLine(string.Join(" ", reversedNumbers));
        }
    }
}
