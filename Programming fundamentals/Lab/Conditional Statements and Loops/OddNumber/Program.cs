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
           
            int oddNum = 0;
            while (true)
            {
                if (oddNum % 2 == 1)
                {
                    oddNum = Math.Abs(int.Parse(Console.ReadLine()));
                    Console.WriteLine($"The number is: {oddNum}");
                    break; 

                }
            }
         Console.WriteLine("Please write an odd number.");
        }
    }
}
