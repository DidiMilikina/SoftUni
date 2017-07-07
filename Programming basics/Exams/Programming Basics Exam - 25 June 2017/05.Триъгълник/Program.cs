using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Триъгълник
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = (4 * n) + 1;
            int height = (2 * n) + 1;

            
            Console.WriteLine(new string('#', width));
            for (int i = 1; i < n; i++)
            {int sharps = width - (2 * i);
                
                Console.Write(new string('.', i));
                Console.Write(new string('#', sharps));
                Console.Write(new string(' ', i));
                Console.Write(new string('#', sharps));
                Console.WriteLine(new string('.', i));
                sharps -= 2;
            }
        }
    }
}
