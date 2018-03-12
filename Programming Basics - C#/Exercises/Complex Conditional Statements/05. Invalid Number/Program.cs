using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var inRange = (number >= 100 && number <= 200) || number == 0;

            if (!inRange)
            {
            } 
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
