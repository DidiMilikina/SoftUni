using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladybugs
{
    class Ladybugs
    {
        static void Main(string[] args)
        {
            int sizeField = int.Parse(Console.ReadLine());
            var indexes = Console.ReadLine()
                .Split(new[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var field = new int[sizeField];
            string input;
            foreach (var ladybugIndex in indexes)
            {
                if (ladybugIndex < 0 || ladybugIndex >= sizeField)
                {
                    continue;
                }
                field[ladybugIndex] = 1;
            }

            while ((input = Console.ReadLine()) != "end")
            {
                var command = input
                    .Split(new[] { ' ' },
                        StringSplitOptions.RemoveEmptyEntries);

                var currentIndex = int.Parse(command[0]);
                var direction = command[1];
                var flyLength = int.Parse(command[2]);

                if (currentIndex < 0 || currentIndex >= sizeField)
                {
                    continue;
                }
                if (field[currentIndex] == 0)
                {
                    continue;
                }

                field[currentIndex] = 0;
                var position = currentIndex;

                // for each movement 
                while (true)
                {
                    if (direction == "right")
                    {
                        position += flyLength;
                    }
                    else
                    {
                        position -= flyLength;
                    }

                    if (position < 0 || position >= sizeField)
                    {
                        break;
                    }

                    //If there is another ladybug
                    if (field[position] == 1)
                    {
                        continue;
                    }
                    else
                    {
                        field[position] = 1;
                        break;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
