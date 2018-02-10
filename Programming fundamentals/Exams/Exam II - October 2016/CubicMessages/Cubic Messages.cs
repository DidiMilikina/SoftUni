using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CubicMessages
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage;

            while ((encryptedMessage = Console.ReadLine()) != "Over!")
            {
                int count = int.Parse(Console.ReadLine());
                Regex validMessageRegex = new Regex(@"^([0-9]+)([a-zA-Z]{" + count + "})([^a-zA-Z]*)$");
                Match matchValidMessage = validMessageRegex.Match(encryptedMessage);

                if (matchValidMessage.Success)
                {
                    string message = matchValidMessage.Groups[2].ToString();
                    Console.Write(message + " == ");
                    var indexes = new List<int>(GetIndexes(matchValidMessage));

                    foreach (var index in indexes)
                    {
                        if (0 <= index && index < message.Length)
                        {
                            Console.Write(message[index]);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }

                    Console.WriteLine();
                }
            }
        }

        private static List<int> GetIndexes(Match matchValidMessage)
        {
            var indexes = new List<int>();
            string leftPart = matchValidMessage.Groups[1].ToString();
            for (int i = 0; i < leftPart.Length; i++)
            {
                if (char.IsDigit(leftPart[i]))
                {
                    indexes.Add(int.Parse(leftPart[i].ToString()));
                }
            }

            string rightPart = matchValidMessage.Groups[3].ToString();
            for (int i = 0; i < rightPart.Length; i++)
            {
                if (char.IsDigit(rightPart[i]))
                {
                    indexes.Add(int.Parse(rightPart[i].ToString()));
                }
            }

            return indexes;
        }
    }
}
