using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Maximum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int commands = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            Stack<int> maxStack = new Stack<int>();

            maxStack.Push(int.MinValue);

            for (int i = 0; i < commands; i++)
            {
                var command = Console.ReadLine().Split().Select(int.Parse).ToArray();
                switch (command[0])
                {
                    case 1:
                        int element = command[1];
                        stack.Push(element);
                        if (element >= maxStack.Peek())
                        {
                            maxStack.Push(element);
                        }
                        break;
                    case 2:
                        int poppedEl = stack.Pop();
                        if (maxStack.Peek() == poppedEl)
                        {
                            maxStack.Pop();
                        }
                        break;
                    case 3:
                        int maxEl = maxStack.Peek();
                        Console.WriteLine(maxEl);
                        break;
                }
            }
        }
    }
}
