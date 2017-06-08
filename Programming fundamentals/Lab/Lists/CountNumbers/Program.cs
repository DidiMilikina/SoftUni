using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int[] counter = new int[1001];

            foreach (var number in numbers)
            {
                counter[number]++;
            }
            for (int i = 0; i < counter.Length; i++)
            {
                if (counter[i] > 0)
                {
                    Console.WriteLine($"{i} -> {counter[i]}");
                }
            }
        }
    }
}
