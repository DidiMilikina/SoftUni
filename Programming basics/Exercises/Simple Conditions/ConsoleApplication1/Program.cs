using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var isMature = age >= 18;
            Console.WriteLine(isMature);
            if (age >= 18 )
            {
                Console.WriteLine("Bira");

            }
            else
            {
                Console.WriteLine("sokche");
            }
           

        }
    }
}
