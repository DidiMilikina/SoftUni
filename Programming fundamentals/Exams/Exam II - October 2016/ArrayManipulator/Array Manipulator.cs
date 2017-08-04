using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            string command = Console.ReadLine();

            while (command != "end")
            {
                if (command.Contains("exchange"))
                {

                }
                else if (command.Contains("max"))
                {

                }
                else if (command.Contains("min"))
                {

                }
                else if (command.Contains("first"))
                {

                }
                else if (command.Contains("last"))
                {

                }
                else
                {
                    
                }
                command = Console.ReadLine();
            }
        }
    }
}
