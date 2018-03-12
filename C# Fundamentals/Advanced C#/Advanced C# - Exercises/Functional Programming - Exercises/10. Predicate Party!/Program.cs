namespace _10.Predicate_Party_
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PredicateParty
    {
        public static void Main()
        {
            var allPeople = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            ExecuteCommandsFromInput(allPeople);
            CommingList(allPeople);
        }

        private static void CommingList(List<string> allPeople)
        {
            if (allPeople.Any())
            {
                var names = string.Join(", ", allPeople);
                Console.WriteLine($"{names} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static void ExecuteCommandsFromInput(List<string> allPeople)
        {
            var command = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "Party!")
            {
                if (command.Length < 3)
                {
                    command = Console.ReadLine()
                        .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    continue;
                }

                switch (command[1])
                {
                    case "StartsWith":
                        ForEachName(command[0], allPeople, n => n.StartsWith(command[2]));
                        break;
                    case "EndsWith":
                        ForEachName(command[0], allPeople, n => n.EndsWith(command[2]));
                        break;
                    case "Length":
                        ForEachName(command[0], allPeople, n => n.Length == int.Parse(command[2]));
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            }
        }

        private static void ForEachName(string command, List<string> allPeople, Func<string, bool> condition)
        {
            for (int i = allPeople.Count - 1; i >= 0; i--)
            {
                if (condition(allPeople[i]))
                {
                    switch (command)
                    {
                        case "Remove":
                            allPeople.RemoveAt(i);
                            break;
                        case "Double":
                            allPeople.Add(allPeople[i]);
                            break;
                    }
                }
            }
        }
    }
}