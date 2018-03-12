using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            var numberOfNumbers = int.Parse(Console.ReadLine());
            var lowestNumber = int.MaxValue;
            for (int i = 0; i < numberOfNumbers; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber < lowestNumber)
                {
                    lowestNumber = currentNumber;
                }
            }
            Console.WriteLine(lowestNumber);
        }
    }
}
