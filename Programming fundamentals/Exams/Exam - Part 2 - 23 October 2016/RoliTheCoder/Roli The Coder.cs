using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoliTheCoder
{
    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Participants { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var eventsById = new Dictionary<int, Event>();
            string input;

            while ((input = Console.ReadLine()) != "Time for Code")
            {
                var line = input
                    .Split(new[] {' '},
                        StringSplitOptions.RemoveEmptyEntries);

                var eventID = 0;

                if (!int.TryParse(line[0], out eventID) || line.Length < 2)
                {
                    continue;
                }

                if (!line[1].StartsWith("#"))
                {
                    continue;
                }

                var participants = line.Skip(2).ToList();
                if (!participants.All(p => p.StartsWith("@")))
                {
                    continue;
                }

                string eventName = null;
                eventName = line[1].Trim('#');

                if (eventsById.ContainsKey(eventID))
                {
                    if (eventsById[eventID].Name == eventName)
                    {
                        eventsById[eventID].Participants.AddRange(participants);
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    var newEvent = new Event
                    {
                        Id = eventID,
                        Name = eventName,
                        Participants = participants
                    };

                    eventsById.Add(eventID, newEvent);
                }
            }

            foreach (KeyValuePair<int, Event> keyValuePair in eventsById)
            {
                keyValuePair.Value.Participants = keyValuePair.Value.Participants.Distinct().ToList();
            }

            var sorted = eventsById
                .OrderByDescending(pair => pair.Value.Participants.Count)
                .ThenBy(pair => pair.Value.Name);

            foreach (var eventPair in sorted)
            {
                Console.WriteLine($"{eventPair.Value.Name} - {eventPair.Value.Participants.Count}");

                eventPair.Value.Participants.Sort();
                foreach (string participant in eventPair.Value.Participants)
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }
}
