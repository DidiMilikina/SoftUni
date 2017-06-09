using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(new[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }
                , StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var lowerCaseWords = new List<string>();
            var mixedCaseWords = new List<string>();
            var upperCaseWords = new List<string>();



            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCaseWords));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCaseWords));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCaseWords));
        }
    }
}
