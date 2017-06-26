using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
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

                Call(phoneNumbers, names);
                Message(phoneNumbers, names);
                    inputLine = Console.ReadLine();
                }
            }

        private static void Message(string[] phoneNumbers, string[] names)
        {
           
        }

        private static void Call(string[] phoneNumbers, string[] names)
        {
            for (int i = 0; i < ; i++)
            {

            }
        }
    }
}