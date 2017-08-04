using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrophonTheGrumpyCat
{
    class Program
    {
        static void Main(string[] args)
        {
            var ratings = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            var entry = long.Parse(Console.ReadLine());
            var typeOfItems = Console.ReadLine();
            var typeOfRatings = Console.ReadLine();

            long left = 0;
            for (long i = 0; i < entry; i++)
            {
              
            }
            long right = 0;
            for (long i = entry + 1; i < ratings.Length; i++)
            {
               
            }

            if (left >= right)
            {
                Console.WriteLine($"Left - {left}");
            }
            else
            {
                Console.WriteLine($"Right - {right}");
            }
        }
    }
}
