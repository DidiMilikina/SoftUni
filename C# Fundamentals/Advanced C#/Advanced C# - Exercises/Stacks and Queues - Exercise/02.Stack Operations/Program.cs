using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var commnds = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numberElementsToPush = commnds[0];
            int numberElementsToPop = commnds[1];
            int elementToLookFor = commnds[2];

            var inputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < numberElementsToPush; i++)
            {
                stack.Push(inputNumbers[i]);
            }
            for (int i = 0; i < numberElementsToPop; i++)
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }
            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (stack.Contains(elementToLookFor))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
        }
    }
}
