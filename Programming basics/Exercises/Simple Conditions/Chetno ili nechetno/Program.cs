using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chetno_ili_nechetno
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var reminder = number % 2;
            if(reminder == 0)
            {
                Console.WriteLine("Even");
            } 
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
