using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetAssault
{
    class Program
    {
        static void Main(string[] args)
        {
            var beehives = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            var hornets = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            for (int i = 0; i < beehives.Count; i++)
            {
                var hornetsPower = hornets.Sum();
                if (hornetsPower > beehives[i])
                {
                    beehives[i] = 0;
                }
                else
                {
                    beehives[i] -= hornetsPower;
                    if (hornets.Count > 0)
                    {
                        hornets.RemoveAt(0);
                    }
                }
            }

            if (beehives.Any(b => b > 0))
            {
                Console.WriteLine(string.Join(" ", beehives.Where(b => b > 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
