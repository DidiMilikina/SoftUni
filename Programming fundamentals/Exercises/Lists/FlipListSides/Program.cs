using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipListSides
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            for (int i = 1; i < numbers.Count / 2; i++)
            {
                
              int newNum = numbers[i];
              numbers[i] = numbers[numbers.Count - 1 - i];
              numbers[numbers.Count - 1 - i] = newNum;  
                
            }
            Console.WriteLine(String.Join(" ", numbers));
                
        }
    }
}
