using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SpyGram
{
    class Program
    {
        class Message
        {
            public string Sender { get; set; }
            public string FullMessage { get; set; }
        }

        static void Main()
        {
            string privateKey = Console.ReadLine();

            Regex rgx = new Regex("^TO:\\s([A-Z]+);\\sMESSAGE:\\s(.+);$");

            string currentMessage = Console.ReadLine();
            List<Message> messages = new List<Message>();

            while (currentMessage != "END")
            {
                if (rgx.IsMatch(currentMessage))
                {
                    var senderName = rgx.Match(currentMessage).Groups[1].Value;
                    int currentPriveKeyIndex = 0;

                    string encryptedMessage = String.Empty;
                    foreach (char currentLetter in currentMessage)
                    {
                        int currenEcryptor = int.Parse(privateKey[currentPriveKeyIndex].ToString());
                        char encryptedCharacter = (char)(currentLetter + currenEcryptor);
                        encryptedMessage += encryptedCharacter;

                        currentPriveKeyIndex++;
                        if (currentPriveKeyIndex == privateKey.Length)
                        {
                            currentPriveKeyIndex = 0;
                        }
                    }

                    messages.Add(new Message()
                    {
                        FullMessage = encryptedMessage,
                        Sender = senderName
                    });
                }

                currentMessage = Console.ReadLine();
            }

            var sortedMessages = messages.OrderBy(message => message.Sender);

            foreach (Message sortedMessage in sortedMessages)
            {
                Console.WriteLine(sortedMessage.FullMessage);
            }
        }
    }
}