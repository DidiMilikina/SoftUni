using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Binary_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputDecimal = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            if (inputDecimal == 0)
            {
                Console.Write(0);
                return;
            }
            while (inputDecimal > 0)
            {
                stack.Push(inputDecimal % 2);
                inputDecimal /= 2;
            }
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
            Console.WriteLine();
        }
    }
}
