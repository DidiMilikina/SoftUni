using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumTopics
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var topicTags = new Dictionary<string, HashSet<string>>();

            while (input != "filter")
            {
                string[] tokens = input.Split(new[] {' ', '-', '>', ','},
                    StringSplitOptions.RemoveEmptyEntries);
                string currentTopic = tokens[0];
                if (!topicTags.ContainsKey(currentTopic))
                {
                    topicTags[currentTopic] = new HashSet<string>();
                }
                for (int i = 1; i < tokens.Length; i++)
                {
                    topicTags[currentTopic].Add("#" + tokens[i]);
                }

                input = Console.ReadLine();
            }

            foreach (var topics in topicTags)
            {
                Console.WriteLine($"{topics.Key} | {string.Join(", ", topics.Value)}");
            }
        }
    }
}
