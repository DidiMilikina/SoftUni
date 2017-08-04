using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HornetComm
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var broadcast = new List<string>();
            var messages = new List<string>();
            var digits = new Regex("[0-9]+");
            var words = new Regex("[a-zA-z]+");
            while (input != "Hornet is Green")
            {
                var tokens = input
                    .Split(new[] { " <-> " },
                    StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                var firstLine = tokens[0];
                var secondLine = tokens[1];
                
                input = Console.ReadLine();
            }
            Console.WriteLine("Broadcasts:");
            if (broadcast.Count > 0)
            {
                foreach (var item in broadcast)
                {
                    Console.WriteLine($"{string.Join(" -> ", item)}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }
            Console.WriteLine("Messages:");
            if (messages.Count > 0)
            {
                foreach (var item in messages)
                {
                    Console.WriteLine($"{string.Join(" -> ", item)}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
