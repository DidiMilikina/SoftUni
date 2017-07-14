using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var random = new Random();
            var rnd = random.Next(0, words.Length);

            for (int i = 0; i < words.Length; i++)
            {
                var word = words[i];
                if (i != rnd)
                {
                    var tempWord = words[rnd];
                    words[rnd] = word;
                    words[i] = tempWord;
                }
            }
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
