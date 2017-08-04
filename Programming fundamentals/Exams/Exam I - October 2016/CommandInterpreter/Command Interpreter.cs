using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split(new[] { ' ' }, 
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string[] commands = Console.ReadLine()
                .Split(new [] { ' '},
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (commands[0] != "end")
            {
                if (commands[0].Equals("reverse"))
                {
                    
                }
                else if (commands[0].Equals("sort"))
                {
                    
                }
                else if (commands[0].Equals("rollLeft"))
                {
                    
                }
                else if (commands[0].Equals("rollRight"))
                {
                    
                }
                commands = Console.ReadLine()
                    .Split(new [] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .ToArray(); 
            }

            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }
    }
}
