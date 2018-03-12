using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var factorial = 1;
            do
            {
                factorial = factorial * num;
                num--; 
            } while (num > 1);
            Console.WriteLine(factorial);

           // for (int i = 2; i < num; i++)
           // {
           //     factorial *= i;
           // }
        }
    }
}
