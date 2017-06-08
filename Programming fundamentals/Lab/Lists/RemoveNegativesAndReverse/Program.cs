using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var result = new List<int>();

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (numbers[i] > 0)
                {
                    result.Add(numbers[i]);
                }
            }
            if (result.Count > 0)
            {
               
                Console.WriteLine(String.Join(" ", result));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}