using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageCharacterDelimiter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split(' ')
                .ToList();

            double sum = 0;
            double countOfCharacters = 0;

            for (int i = 0; i < elements.Count; i++)
            {
                string words = elements[i];
                countOfCharacters += words.Length;
                for (int j = 0; j < words.Length; j++)
                {
                    sum += words[j];
                }
            }

            char charDelimeter = (char) ((int) (sum / countOfCharacters));
            string delimeter = charDelimeter.ToString().ToUpper();
            Console.WriteLine(string.Join(delimeter, elements));
        }
    }
}