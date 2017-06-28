using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine()
                .ToLower()
                .Split(' ');

            var result = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (!result.ContainsKey(word))
                {
                    result[word] = 0;
                }
                result[word]++;
            }

            var oddNumber = new List<string>();

            foreach (var kv in result)
            {
                var value = kv.Value;
                if (value % 2 != 0)
                {
                    oddNumber.Add(kv.Key);
                }
            }
            Console.WriteLine(string.Join(", ", oddNumber));
        }
    }
}