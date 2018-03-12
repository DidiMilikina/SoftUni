using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Stack_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Stack<long> stack = new Stack<long>();

            stack.Push(1);
            stack.Push(1);

            for (var i = 2; i < number; i++)
            {
                long secondNum = stack.Pop();
                long firstNum = stack.Pop();
                long nextNum = firstNum + secondNum;

                stack.Push(firstNum);
                stack.Push(secondNum);
                stack.Push(nextNum);
            }
            Console.WriteLine(stack.Peek());
        }
    }
}
