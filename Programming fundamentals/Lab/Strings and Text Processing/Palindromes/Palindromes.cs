using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine()
                .Split(new[] { ' ', ',', '.', '?', '!' },
                StringSplitOptions.RemoveEmptyEntries);

            var palindromes = new List<string>();

            foreach (var word in text)
            {
                var reversedWord = "";

                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reversedWord += word[i];
                }

                if (word == reversedWord)
                {
                    palindromes.Add(word);
                }
            }

            palindromes = palindromes
                .Distinct()
                .OrderBy(w => w)
                .ToList();

            Console.WriteLine(string.Join(", ", palindromes));
        }
    }
}
