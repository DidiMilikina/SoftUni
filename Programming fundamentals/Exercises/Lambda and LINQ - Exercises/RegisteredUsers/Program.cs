using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisteredUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            var registeredUsers = new Dictionary<string, DateTime>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputParams = input.Split(new[] { ' ', '-', '>' },
                    StringSplitOptions.RemoveEmptyEntries);
                string username = inputParams[0];
                DateTime registeryDate = DateTime.ParseExact(inputParams[1],
                    "dd/MM/yyyy",
                    CultureInfo.InvariantCulture);

                registeredUsers[username] = registeryDate;

                input = Console.ReadLine();
            }

            Dictionary<string, DateTime> orderedUsernames =
                registeredUsers
                    .Reverse()
                    .OrderBy(x => x.Value)
                    .Take(5)
                    .OrderByDescending(x => x.Value)
                    .ToDictionary(x => x.Key, x => x.Value);

            foreach (var inOrder in orderedUsernames)
            {
                Console.WriteLine($"{inOrder.Key}");
            }
        }
    }
}