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
            var goshoHelath = 100;
            var round = 1;
            string peshoCw = $"Pesho used Roundhouse kick and reduced Gosho to {peshoHealth} health.";
            string goshoCw = $"Gosho used Thunderous fist and reduced Pesho to {goshoHelath} health.";

            while (true) 
            {
                
                if(round % 2 == 1)
                {
                    goshoHelath -= peshoDamage;
                }
                else
                {
                    peshoHealth -= goshoDamage;
                }

                round++;

                if (peshoHealth <= 0)
                {
                    break;

                }
                else if (goshoHelath <= 0)
                {
                    break;
                }
                if(round % 3 == 0)
                {
                    goshoHelath += 10;
                    peshoHealth += 10;

                }
                

            }
            Console.WriteLine(round - 1);

        }
    }
}
