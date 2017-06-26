using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnunionLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var primalList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var numberOfLines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfLines; i++)
            {
                List<int> currentList = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToList();
                for (int j = 0; j < currentList.Count; j++)
                {
                    int currentElement = currentList[j];
                    if (primalList.Contains(currentElement))
                    {
                        primalList.RemoveAll(e => e == currentElement);
                    }
                    else
                    {
                        primalList.Add(currentElement);
                    }
                }
            }

            primalList.Sort();
            Console.WriteLine(string.Join(" ", primalList));
        }
    }
}