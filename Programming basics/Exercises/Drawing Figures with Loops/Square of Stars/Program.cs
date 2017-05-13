using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var sideOfSquare = int.Parse(Console.ReadLine());
            for (var row = 1; row <= sideOfSquare; row++)
            {
                Console.Write("*");
                for (var col = 1; col < sideOfSquare; col++)
                {
                    Console.Write(" *");
                    
                }
                Console.WriteLine();
            }
        }
    }
}
