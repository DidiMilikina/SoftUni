using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberPokemonsFirstPlayer = int.Parse(Console.ReadLine());
            var numberPokemonsSecondPlayer = int.Parse(Console.ReadLine());
            var maxBattles = int.Parse(Console.ReadLine());

            var counter = 0;
            for (int i = 1; i <= numberPokemonsFirstPlayer; i++)
            { 
                for (int j = 1; j <= numberPokemonsSecondPlayer; j++)
                {
                   
                    if (counter == maxBattles)
                    {
                        break;
                    }

                    Console.Write($"({i} <-> {j}) ");
                    counter++;
                }
            }
        }
    }
}
