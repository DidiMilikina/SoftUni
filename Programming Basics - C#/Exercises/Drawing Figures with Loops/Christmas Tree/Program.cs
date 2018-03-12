using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 0;  row <= n;  row++)
            {
                Console.Write(new string(' ', n - row));
                Console.Write(new string('*', row));
                Console.Write(" | ");
                Console.WriteLine(new string('*', row));
            }
        }
    }
}
