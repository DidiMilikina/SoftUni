using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawAFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeader(n);

            for (int i = 0; i < n - 2; i++)
            {
                Console.Write('-');
                for (int j = 1; j < n; j++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine('-');

            }
            PrintHeader(n);
        }
        static void PrintHeader(int n)
        {
            Console.WriteLine(new string('-', n * 2));
        }
       
    }
}
