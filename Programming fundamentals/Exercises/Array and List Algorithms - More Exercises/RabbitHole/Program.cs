using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitHole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> path = Console.ReadLine()
                .Split(' ')
                .ToList();
            int totalEnergy = int.Parse(Console.ReadLine());
            int position = 0;

            while (true)
            {
                string[] tokens = path[position]
                    .Split('|');

                switch (tokens[0])
                {
                    case "Right":
                        position = (position + int.Parse(tokens[1])) % path.Count;
                        totalEnergy -= int.Parse(tokens[1]);
                        if (totalEnergy <= 0)
                        {
                            Console.WriteLine("You are tired. You can't continue the mission.");
                            return;
                        }
                        break;

                    case "Left":
                        int temp = int.Parse(tokens[1]) - position;
                        position = (temp + int.Parse(tokens[1])) % path.Count;
                        totalEnergy -= int.Parse(tokens[1]);
                        if (totalEnergy <= 0)
                        {
                            Console.WriteLine("You are tired. You can't continue the mission.");
                            return;
                        }
                        break;

                    case "Bomb":
                        int energyTaken = int.Parse(tokens[1]);
                        totalEnergy -= energyTaken;
                        path.RemoveAt(position);
                        if (totalEnergy <= 0)
                        {
                            Console.WriteLine("You are dead due to bomb explosion!");
                            return;
                        }
                            break;

                    case "RabbitHole":
                        Console.WriteLine("You have 5 years to save Kennedy!");
                        return;
                }
            }
        }
    }
}