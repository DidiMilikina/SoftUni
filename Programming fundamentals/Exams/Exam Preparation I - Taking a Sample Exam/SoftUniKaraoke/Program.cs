using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniKaraoke
{
    class Program
    {
        static void Main(string[] args)
        {
            var partcipants = Console.ReadLine()
                .Split(',')
                .Select(a => a.Trim())
                .ToArray();

            var songs = Console.ReadLine()
                .Split(',')
                .Select(a => a.Trim())
                .ToArray();

            var participantAwards = new Dictionary<string, SortedSet<string>>();

            var line = Console.ReadLine();

            while (line != "dawn")
            {
                var tokens = line
                    .Split(',')
                    .Select(a => a.Trim())
                    .ToArray();

                var participant = tokens[0];
                var song = tokens[1];
                var award = tokens[2];

                if (songs.Contains(song) && partcipants.Contains(participant))
                {
                    if (!participantAwards.ContainsKey(participant))
                    {
                       participantAwards[participant] = new SortedSet<string>();
                        //sort awards in alphabetical order
                    }
                     participantAwards[participant].Add(award);
                }

                line = Console.ReadLine();
            }
            if (!participantAwards.Any())
            {
                Console.WriteLine("No awards");
                return;
            }
            
            var sortedPartcipantAwards = participantAwards
                .OrderByDescending(a => a.Value.Count)
                //if we have more than 1 participant with same awards like other participant we should ... 
                .ThenBy(a => a.Key)
                //sort participants in alphabetical order 
                .ToDictionary(a => a.Key, a => a.Value);

            foreach (var partcipantAward in sortedPartcipantAwards)
            {
                var partcipant = partcipantAward.Key;
                var awards = partcipantAward.Value;

                Console.WriteLine($"{partcipant}: {awards.Count} awards");
                foreach (var award in awards)
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
    }
}
