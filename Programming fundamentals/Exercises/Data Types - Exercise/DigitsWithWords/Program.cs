using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitsWithWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();

            if(n == "nine")
            {
                Console.WriteLine("9");
            }
            else if(n == "eight")
            {
                Console.WriteLine("8");
            }
            else if (n == "seven")
            {
                Console.WriteLine("7");
            }
            else if (n == "six")
            {
                Console.WriteLine("6");
            }
            else if (n == "five")
            {
                Console.WriteLine("5");
            }
            else if (n == "four")
            {
                Console.WriteLine("4");
            }
            else if (n == "three")
            {
                Console.WriteLine("3");
            }
            else if (n == "two")
            {
                Console.WriteLine("2");
            }
            else if (n == "one")
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
