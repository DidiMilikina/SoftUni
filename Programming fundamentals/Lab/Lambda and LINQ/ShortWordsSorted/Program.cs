using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimiters = ".,:;()[]\"'/\\!? ".ToCharArray();

            string[] words = Console.ReadLine()
                .ToLower()
                .Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .Where(w => w.Length < 5)
                .OrderBy(w => w)
                .ToArray();

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
