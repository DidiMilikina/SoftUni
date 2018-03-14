using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Balanced_Parenth
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            if (input.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
                // Environment.Exit(0);
            }

            char[] openingPar = new [] {'(', '[', '{'};
            char[] closingPar = new [] {')', ']', '}'};

            Stack<char> stack = new Stack<char>();
            foreach (var element in input)
            {
                if (openingPar.Contains(element))
                {
                    stack.Push(element);
                }
                else if(closingPar.Contains(element))
                {
                    var lastElement = stack.Pop();
                    int openingIndex = Array.IndexOf(openingPar, lastElement);
                    int closingIndex = Array.IndexOf(closingPar, element);

                    if (openingIndex != closingIndex)
                    {
                        Console.WriteLine("NO");
                        return;
                        // Environment.Exit(0);
                    }
                }
            }
            if (stack.Any())
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
