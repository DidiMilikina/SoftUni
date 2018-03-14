using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Inferno_III
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            ExecuteCommands(numbers);

            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void ExecuteCommands(List<int> numbers)
        {
            var input = Console.ReadLine().Split(';');
            var exFilters = new Queue<KeyValuePair<string, int>>();

            while (input[0] != "Forge")
            {
                if (input.Length < 3)
                {
                    continue;
                }

                var command = input[0];
                var type = input[1];
                var param = int.Parse(input[2]);

                switch (command)
                {
                    case "Exclude":
                        exFilters.Enqueue(new KeyValuePair<string, int>(type, param));
                        break;
                    case "Reverse":
                        if (exFilters.Count > 0)
                        {
                            exFilters.Dequeue();
                        }
                        break;
                }
                input = Console.ReadLine().Split(';');
            }

        }
    }
}
