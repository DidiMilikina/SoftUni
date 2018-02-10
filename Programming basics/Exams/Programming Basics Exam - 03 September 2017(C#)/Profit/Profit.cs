using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit
{
    class Profit
    {
        static void Main(string[] args)
        {
            int monets1 = int.Parse(Console.ReadLine());
            int monets2 = int.Parse(Console.ReadLine());
            int monets5 = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int m1 = 0; m1 <= monets1; m1++)
            {
                for (int m2 = 0; m2 <= monets2; m2++)
                {
                    for (int m5 = 0; m5 <= monets5; m5++)
                    {
                        if (m1 * 1 + m2 * 2 + m5 * 5 == sum)
                        {
                            Console.WriteLine($"{m1} * 1 lv. + {m2} * 2 lv. + {m5} * 5 lv. = {sum} lv.");
                        }
                    }
                }   
            }
        }
    }
}
