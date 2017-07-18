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
                string[] tokens = input.Split(new string[] {" -> "},
                    StringSplitOptions.RemoveEmptyEntries);
                string currentTopic = tokens[0];
                string[] tags = tokens[1].Split(new string[] { ", " },
                    StringSplitOptions.RemoveEmptyEntries);


                if (!topicTags.ContainsKey(currentTopic))
                {
                    topicTags[currentTopic] = new HashSet<string>();
                }

                foreach (var tag in tags)
                {
                    topicTags[currentTopic].Add(tag);
                }

                input = Console.ReadLine();
            }
            input = Console.ReadLine();

            List<string> tagsToFilter = input.Split(new string[] { ", " }, 
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            foreach (var kvp in topicTags)
            {
                string topic = kvp.Key;
                var tags = kvp.Value;
                bool contained = !tagsToFilter.Except(tags).Any();
                if (contained)
                {
                    Console.WriteLine($"{topic} | #{string.Join(", #", tags)}");
                }

            }
        }
    }
}
