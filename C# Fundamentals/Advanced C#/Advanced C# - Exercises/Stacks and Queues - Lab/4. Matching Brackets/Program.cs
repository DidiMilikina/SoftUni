using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();

            for (int counter = 0; counter < input.Length; counter++)
            {
                char ch = input[counter];
                if (ch == '(')
                {
                    stack.Push(counter);
                }
                else if (ch == ')')
                {
                    int startIndex = stack.Pop();
                    var length = counter - startIndex + 1;
                    string contents = input.Substring(startIndex, length);
                    Console.WriteLine(contents);
                }
            }
        }
    }
}
