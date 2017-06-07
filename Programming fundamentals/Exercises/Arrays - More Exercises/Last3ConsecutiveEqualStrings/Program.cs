using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last3ConsecutiveEqualStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine()
                .Split(' ');

            int count = 1;

            for (int i = array.Length - 1; i > 0; i--)
            {
                if(array[i] == array[i - 1])
                {
                    count++;
                    if(count == 3)
                    {
                        Console.WriteLine("{0} {0} {0}", array[i]);
                        break;
                    }
                }
                else
                {
                    count = 1;
                }
            }
        }
    }
}
