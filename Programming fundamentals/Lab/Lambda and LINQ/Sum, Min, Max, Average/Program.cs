
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum__Min__Max__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int numToAdd = int.Parse(Console.ReadLine());
                numbers.Add(numToAdd);
            }

            Console.WriteLine($"Sum = {0}", numbers.Sum());
            Console.WriteLine($"Min = {0}", numbers.Min());
            Console.WriteLine($"Max = {0}", numbers.Max());
            Console.WriteLine($"Average = {0}", numbers.Average());

        }
    }
}
