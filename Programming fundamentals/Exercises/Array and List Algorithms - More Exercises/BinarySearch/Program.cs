using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int numberToFind = int.Parse(Console.ReadLine());
            int countLinearSearch = LinearMethod(numbers, numberToFind);
            int countBinarySearch = BinaryMethod(numbers, numberToFind);
            
            if (numbers.BinarySearch(numberToFind) >= 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.WriteLine($"Linear search made {countLinearSearch} iterations");
            Console.WriteLine($"Binary search made {countBinarySearch} iterations");
        }

        private static int BinaryMethod(List<int> numbers, int numberToFind)
        {
            numbers.Sort();
            int min = 0;
            int max = numbers.Count - 1;
            int counter = 0;
            while (min <= max)
            {
                int middlePoint = (min + max) / 2;

                counter++;
                if (numbers[middlePoint] < numberToFind)
                {
                    min = middlePoint + 1;
                }
                if (numbers[middlePoint] > numberToFind)
                {
                    max = middlePoint - 1;
                }
                if (numbers[middlePoint] == numberToFind)
                {
                    break;
                }
            }
            return counter;
        }

        private static int LinearMethod(List<int> numbers, int numberToFind)
        {
            var count = 0;
            foreach (var number in numbers)
            {
                count++;
                if (number == numberToFind)
                {
                    break;
                }
            }
            return count;
        }
    }
}