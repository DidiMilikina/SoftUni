using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Stack<string> text = new Stack<string>();

            for (int i = 0; i < lines; i++)
            {
                var tokens = Console.ReadLine().Trim()
                    .Split(' ').ToArray();

                var command = int.Parse(tokens[0]);

                switch (command)
                {
                    case 1:
                        if (text.Count == 0)
                        {
                            text.Push(tokens[1]);
                        }
                        else
                        {
                            var lastElements = text.Peek();
                            lastElements += tokens[1];
                            text.Push(lastElements);
                        }
                        break;

                    case 2:
                        var count = int.Parse(tokens[1]);
                        var elements = text.Peek();
                        elements = elements.Substring(0, elements.Length - count);
                        text.Push(elements);
                        break;

                    case 3:
                        var lastString = text.Peek();
                        var index = int.Parse(tokens[1]);
                        Console.WriteLine(lastString[index - 1]);
                        break;
                    case 4:
                        text.Pop();
                        break;
                }
            }
        }
    }
}
