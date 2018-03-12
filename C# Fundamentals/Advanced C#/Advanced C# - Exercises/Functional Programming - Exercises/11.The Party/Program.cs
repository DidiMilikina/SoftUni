using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.The_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine()
                .Split(' ')
                .ToList();
            var filters = new List<string>();

            string endCommand = Console.ReadLine();

            while (endCommand != "Print")
            {
                var commands = endCommand
                    .Split(';');

                if (commands[0]  == "Add filter")
                {
                    filters.Add(commands[1] + " " + commands[2]);
                }
                else if (commands[0] == "Remove filter")
                {
                    filters.Remove(commands[1] + " " + commands[2]);
                }

                endCommand = Console.ReadLine();
            }

            foreach (var filter in filters)
            {
                var commands = filter.Split(' ');
                if (commands[0] == "Starts")
                {
                    names = names.Where(n => !n.StartsWith(commands[2])).ToList();
                }
                else if (commands[0] == "Ends")
                {
                    names = names.Where(n => !n.EndsWith(commands[2])).ToList();
                }
                else if (commands[0] == "Length")
                {
                    names = names.Where(n => n.Length != int.Parse(commands[1])).ToList();
                }
                else if (commands[0] == "Contains")
                {
                    names = names.Where(n => !n.Contains(commands[1])).ToList();
                }
            }

            if (names.Any())
            {
                Console.WriteLine(string.Join(" ", names));
            }
        }
    }
}
