using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintingTriangle(n);
        }

        static void PrintingTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintLine(i);
            }
            for (int i = n - 1; i >= 1; i--)
            {
                PrintLine(i);
            }
        }
        static void PrintLine(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

    }
}
