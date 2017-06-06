using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRepeater
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());

            StaticString(name, number);
            Console.WriteLine();
        }

        static void StaticString(string name, int number)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(name);
            }
            return;
          
        } 
    }
}
