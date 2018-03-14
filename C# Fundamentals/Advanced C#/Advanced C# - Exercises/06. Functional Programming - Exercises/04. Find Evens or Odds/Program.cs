using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            string command = Console.ReadLine();

            var numbers = Enumerable.Range(input[0], input[1] - input[0] + 1);
            Predicate<int> isEvenPredicate = n => n % 2 == 0;
            PrintNums(numbers, command, isEvenPredicate);
        }

        private static void PrintNums(IEnumerable<int> numbers, string command, Predicate<int> isEvenPredicate)
        {
            List<int> result = new List<int>();
            foreach (var number in numbers)
            {
                if (isEvenPredicate(number) && command == "even")
                {
                    result.Add(number);
                }
                else if (!isEvenPredicate(number) && command == "odd")
                {
                    result.Add(number);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
