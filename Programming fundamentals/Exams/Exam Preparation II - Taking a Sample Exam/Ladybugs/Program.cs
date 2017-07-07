using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeField = int.Parse(Console.ReadLine());
            var indexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var ladybugs = new int[sizeField];
            string input = Console.ReadLine();

            while (input != "end")
            {
                var command = input
                    .Split()
                    .ToArray();

                var firstIndex = int.Parse(command[0]);
                var direction = command[1];
                var secondIndex = int.Parse(command[2]);

            }
        }
    }
}
