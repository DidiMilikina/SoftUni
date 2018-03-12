using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Number_in_Range__1._._._100_
{
    class Program
    {
        static void Main(string[] args)
        {
            var validNumber = int.Parse(Console.ReadLine());
            while (validNumber < 1 || validNumber > 100)
            {
                Console.WriteLine("Invalid number!");
                validNumber = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The number is: {validNumber}");
        }
    }
}
