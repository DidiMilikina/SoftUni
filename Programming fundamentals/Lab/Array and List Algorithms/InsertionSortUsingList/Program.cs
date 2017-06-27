using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortUsingList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            List<int> newList = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                bool inserted = false;

                int currentElement = numbers[i];

                for (int index = 0; index < newList.Count; index++)
                {
                    int currentListElement = newList[index];
                    if (currentElement <= currentListElement)
                    {
                        inserted = true;
                        newList.Insert(Math.Max(0, index), currentElement);
                        break;
                    }
                }

                if (!inserted)
                {
                    newList.Add(currentElement);
                }
            }

            Console.WriteLine(string.Join(" ", newList));
        }
    }
}