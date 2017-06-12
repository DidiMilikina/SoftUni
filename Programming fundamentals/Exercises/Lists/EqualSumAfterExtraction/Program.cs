using System;
using System.Linq;

namespace EqualSumAfterExtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var secondList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var firstListSum = 0;
            var secondListSum = 0;


            foreach (var element in firstList)
            {
                firstListSum += element;
                while (secondList.Contains(element))
                {
                    secondList.Remove(element);
                }
            }

            secondListSum = secondList.Sum();

            if (firstListSum == secondListSum)
            {
                Console.WriteLine($"Yes. Sum: {secondListSum}");
            }
            else
            {
                int difference = Math.Abs(firstListSum - secondListSum);
                Console.WriteLine($"No. Diff: {difference}");
            }
        }
    }
}