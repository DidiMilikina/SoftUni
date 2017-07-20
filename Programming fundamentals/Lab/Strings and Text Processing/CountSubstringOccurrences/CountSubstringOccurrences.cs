using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string pattern = Console.ReadLine().ToLower();
            int counter = 0;
            int index = 0;

            while (true)
            {
                index = text.IndexOf(pattern, index);
                if (index < 0)
                {
                    break;
                }
                else
                {
                    counter++;
                    index++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
