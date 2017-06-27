using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHistogram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ');

            List<string> foundWords = new List<string>();
            List<int> wordsCount = new List<int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (foundWords.Contains(words[i]))
                {
                    int wordIndex = foundWords.IndexOf(words[i]);
                    wordsCount[wordIndex]++;
                }
                else
                {
                    foundWords.Add(words[i]);
                    wordsCount.Add(1);
                }
                    
            }

            bool hasSwapped = true;
            while (hasSwapped)
            {
                hasSwapped = false;
                for (int i = 0; i < wordsCount.Count - 1; i++)
                {

                    if (wordsCount[i] < wordsCount[i + 1])
                    {
                            int temp = wordsCount[i];
                            wordsCount[i] = wordsCount[i + 1];
                            wordsCount[i + 1] = temp;

                            string tempWord = foundWords[i];
                            foundWords[i] = foundWords[i + 1];
                            foundWords[i + 1] = tempWord;

                        hasSwapped = true;
                    }
                }
            }
            
            for (int i = 0; i < foundWords.Count; i++)
            {
                double currentPercentage =  (wordsCount[i] * 100.0) / words.Length;

                Console.WriteLine($"{foundWords[i]} -> {wordsCount[i]} times ({currentPercentage:f2}%)");
            }
        }   
    }
}