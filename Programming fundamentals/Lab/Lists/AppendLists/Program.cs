using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbersInInput = Console.ReadLine()
                .Split('|')
                .ToArray();

            var result = new List<string>();
            Array.Reverse(numbersInInput);

            foreach (var token in numbersInInput)
            {
                string[] numbers = token.Split(' ');

                foreach (var nums in numbers)
                {

                    if (nums != "")
                    {
                        result.Add(nums);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
