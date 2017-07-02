using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JapaneseRoulette
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var strengtAndDirection = Console.ReadLine()
                .Split(' ')
                .ToArray();
           
            var isDead = false;
            for (int i = 0; i < strengtAndDirection.Length; i++)
            {
                var entry = strengtAndDirection[i];

                string[] tokens = entry
                    .Split(',');
                var strengt = int.Parse(tokens[0]);
                var direction = tokens[1];
                strengt %= numbers.Length;

                if (direction == "Left")
                {
                    for (int j = 0; j < strengt; j++)
                    {
                        int temp = numbers[0];
                        for (int k = 1; k < numbers.Length - 1; k++)
                        {
                            numbers[k] = numbers[k + 1];
                        }

                        numbers[numbers.Length - 1] = temp;
                    }
                }
                else
                {
                    for (int j = 0; j < strengt; j++)
                    {
                        int temp = numbers[numbers.Length - 1];
                        for (int k = numbers.Length - 1; k > 0; k--)
                        {
                            numbers[k] = numbers[k - 1];
                        }

                        numbers[0] = temp;
                    }
                }

                var muzzle = numbers[2];

                if (muzzle == 1)
                {
                    Console.WriteLine($"Game over! Player {i} is dead.");
                    isDead = true;
                    break;
                }

                int anotherTemp = numbers[numbers.Length - 1];
                for (int k = numbers.Length - 1; k > 0; k--)
                {
                    numbers[k] = numbers[k - 1];
                }

                numbers[0] = anotherTemp;

            }

            if (!isDead)
            {
                Console.WriteLine("Everybody got lucky!");
            }
        }
    }
}