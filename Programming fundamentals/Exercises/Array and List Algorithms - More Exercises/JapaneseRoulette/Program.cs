using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.JapaneseRolette
{
    class JapaneseRolette
    {
        static void Main(string[] args)
        {
            var bullets = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var comands = Console.ReadLine()
                .Split(' ')
                .ToList();

            int bulletIndex = 0;
            bool isDead = false;

            for (int i = 0; i < bullets.Count; i++)
            {
                if (bullets[i] == 1)
                {
                    bulletIndex = i;
                    break;
                }
            }
            for (int i = 0; i < comands.Count; i++)
            {
                string[] token = comands[i].Split(',');
                int rotation = int.Parse(token[0]);
                string direction = token[1];

                if (direction == "Right")
                {
                    bulletIndex = (bulletIndex + rotation) % bullets.Count;
                }

                else 
                {
                    if (bulletIndex - rotation < 0)
                    {
                        bulletIndex = bullets.Count - (Math.Abs(bulletIndex - rotation) % bullets.Count);
                    }
                    else
                    {
                        bulletIndex = bulletIndex - rotation;
                    }
                }

                if (bulletIndex == 2)
                {
                    Console.WriteLine($"Game over! Player {i} is dead.");
                    isDead = true;
                    return;
                }

                bulletIndex = bulletIndex + 1 == bullets.Count ? 0 : bulletIndex + 1;
            }
            if (!isDead)
            {
                Console.WriteLine("Everybody got lucky!");

            }
        }
    }
}