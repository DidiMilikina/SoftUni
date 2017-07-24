using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placeholders
{
    class Placeholders
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputParams = input
                    .Split(new[] {"->"},
                        StringSplitOptions.RemoveEmptyEntries);
                string sentence = inputParams[0]
                    .Trim();
                string[] elements = inputParams[1]
                    .Trim()
                    .Split(new[] {", "}
                        , StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < elements.Length; i++)
                {
                    string placeholder = "{" + i + "}";
                    sentence = sentence.Replace(placeholder, elements[i]);
                }

                Console.WriteLine(sentence);
                input = Console.ReadLine();
            }
        }
    }
}
