using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ')
                .ToArray();

            bool hasSwapped = true;

            while (hasSwapped)
            {
                hasSwapped = false;

                for (int i = 0; i < words.Length - 1; i++)
                {
                    if (words[i].CompareTo(words[i + 1]) > 0)
                    {
                        string temp = words[i];
                        words[i] = words[i + 1];
                        words[i + 1] = temp;
                        hasSwapped = true;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", words));
            
        }
    }
}