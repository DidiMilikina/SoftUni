using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine();

            Func<string, int> parser = n => int.Parse(n);

            Console.WriteLine(numbers.Split(new string[] { ", " },
                    StringSplitOptions.RemoveEmptyEntries)
                .Select(parser)
                .Count());

            Console.WriteLine(numbers.Split(new string[] { ", " },
                    StringSplitOptions.RemoveEmptyEntries)
                .Select(parser)
                .Sum());
        }
    }
}
