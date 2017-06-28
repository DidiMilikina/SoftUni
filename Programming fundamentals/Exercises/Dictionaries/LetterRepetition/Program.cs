using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLetters = Console.ReadLine();

            var lettersCount = new Dictionary<char, int>();

            foreach (var letter in inputLetters)
            {
                if (!lettersCount.ContainsKey(letter))
                {
                    lettersCount[letter] = 0;
                }
                      lettersCount[letter]++;   
                             
            }
            
            foreach (var pair in lettersCount)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}