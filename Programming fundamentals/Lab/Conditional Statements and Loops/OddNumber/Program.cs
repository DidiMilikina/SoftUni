using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                int number = int.Parse(Console.ReadLine());
                if (Math.Abs(number % 2) == 1)
                {
                    Console.WriteLine("The number is: " + Math.Abs(number));
                    break;
                }
                Console.WriteLine("Please write an odd number.");
            }

        }
    }
}
