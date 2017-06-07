using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine()
                .Split(' ');
            string[] names = Console.ReadLine()
                .Split(' ');

            string inputLine = Console.ReadLine();

            while (inputLine != "done")
            {
                PrintElements(names, phoneNumbers, inputLine);
                inputLine = Console.ReadLine();
            }
        }

        private static void PrintElements(string[] names, string[] phoneNumbers, string inputLine)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if(names[i] == inputLine)
                {
                    Console.WriteLine($"{names[i]} -> {phoneNumbers[i]}");
                }
            }
        }       
    }
}
