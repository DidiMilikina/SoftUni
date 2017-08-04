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
            long[] field = new long[sizeField];
            long[] LadybugIndexese = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();
            var command = Console.ReadLine();

            for (int i = 0; i < field.Length; i++)
            {
                for (int j = 0; j < LadybugIndexese.Length; j++)
                {
                    if (i == LadybugIndexese[j])
                    {
                        field[i] = 1;
                    }
                }
            }

            while (command != "end")
            {
                var tokens = command.Split();
                var index = int.Parse(tokens[0]);
                var direction = command[1];
                var jumpPower = int.Parse(tokens[2]);

                if (direction.Equals("left"))
                {
                    field[index] = 0;
                    long flyDistance = index - jumpPower;

                    if (field[flyDistance] == 0)
                    {
                        field[flyDistance] = 1;
                        break;
                    }
                    else
                    {
                        flyDistance += jumpPower;
                    }
                }
                else if(direction.Equals("right"))
                {
                    field[index] = 0;
                    long flyDistance = index - jumpPower;

                    if (field[flyDistance] == 0)
                    {
                        field[flyDistance] = 1;
                        break;
                    }
                    else
                    {
                        flyDistance += jumpPower;
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
