using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = char.Parse(Console.ReadLine().ToLower());
            var second = char.Parse(Console.ReadLine().ToLower());
            var third = char.Parse(Console.ReadLine().ToLower());

            int combinations = 0;
            for (char i = first; i <= second; i++)
            {
                if (i == third)
                {
                    continue;
                }
                for (char j = first; j <= second; j++)
                {
                    if (j == third)
                    {
                        continue;
                    }
                    for (char k = first; k <= second; k++)
                    {
                        if (k == third)
                        {
                            continue;
                        }
                        combinations++;

                        Console.Write($"{i}{j}{k} ");
                    }
                }

            }
            Console.Write($"{combinations}");
            Console.WriteLine();

        }
    }
}
