using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {

            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            var reminder = pokePower / 2;
            var temp = 0;
            var counter = 0;

            while (pokePower >= distance)
            {
                temp = pokePower - distance;
                if (temp == reminder && exhaustionFactor != 0)
                {
                    temp = temp / exhaustionFactor;
                }
                pokePower = temp;
                counter++;
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(counter);
        }
    }
}
