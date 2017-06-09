using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    
                    
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
