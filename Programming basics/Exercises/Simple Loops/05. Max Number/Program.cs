using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var numberOfNumbers = int.Parse(Console.ReadLine());
            var greatestNumber = int.MinValue;
            for (int i = 0; i < numberOfNumbers; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                if (currentNumber > greatestNumber)
                {
                    greatestNumber = currentNumber;
                }
            }
            Console.WriteLine(greatestNumber);
            }
        }
    }
