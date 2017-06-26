using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            var peshoDamage = int.Parse(Console.ReadLine());
            var goshoDamage = int.Parse(Console.ReadLine());

            var peshoHealth = 100;
            var goshoHealth = 100;
            var round = 1;

            while (true) 
            {
                
                if(round % 2 == 1)
                {
                    goshoHealth -= peshoDamage;
                    if (goshoHealth > 0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                    }
                }
                else
                {
                    peshoHealth -= goshoDamage;
                    if (peshoHealth > 0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                    }  
                }

                if (peshoHealth <= 0)
                {
                    Console.WriteLine($"Gosho won in {round}th round.");
                    break;

                }
                else if (goshoHealth <= 0)
                {
                    Console.WriteLine($"Pesho won in {round}th round.");
                    break;
                }
                if(round % 3 == 0)
                {
                    goshoHealth += 10;
                    peshoHealth += 10;

                }
                round++;

            }
        }
    }
}
