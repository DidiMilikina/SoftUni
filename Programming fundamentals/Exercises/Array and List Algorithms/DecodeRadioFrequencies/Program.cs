using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeRadioFrequencies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frequencesInput = Console.ReadLine()
                .Split(' ');

            List<char> endMessage = new List<char>();
            for (int i = 0; i < frequencesInput.Length; i++)
            {
                string[] tokens = frequencesInput[i].Split('.');
                int firstFreq = int.Parse(tokens[0]);
                int secondFreq = int.Parse(tokens[1]);

                char firstLetter = (char) firstFreq;
                char secondLetter = (char) secondFreq;

                if (firstFreq != 0)
                {
                    endMessage.Insert(i, firstLetter);
                }
                if (secondFreq != 0)
                {
                    endMessage.Insert(i, secondLetter);
                }                
            }
            endMessage.Reverse();
            Console.WriteLine(string.Join("", endMessage));
        }
    }
}