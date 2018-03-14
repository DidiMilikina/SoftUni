using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Array.Sort(input, (x, y) =>
            {
                if (x % 2 == 0 && y % 2 != 0)
                {
                    return -1;
                }
                if (x % 2 != 0 && y % 2 == 0)
                {
                    return 1;
                }
                if (x > y)
                {
                    return 1;
                }
                if (x < y)
                {
                    return -1;
                }
                return 0;
            });
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
