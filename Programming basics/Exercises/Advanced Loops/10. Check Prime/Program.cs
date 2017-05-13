using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var isPrime = true;
            var sqrtOfNum = Math.Sqrt(number);

            if (number >= 2)
            {
                for (int i = 2; i <= sqrtOfNum; i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    Console.WriteLine("Not prime");
                }
            }
            else
            {
                Console.WriteLine("Not prime");
            }
            
        }
    }
}


