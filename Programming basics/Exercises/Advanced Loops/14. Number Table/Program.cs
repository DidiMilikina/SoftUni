using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Number_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            for (int row = 0; row < number; row++)
            {
                for (int col = 0; col < number; col++)
                {
                    var num = row + col + 1;
                    if (num > number)
                    {
                        num = 2 * number - num;
                    }
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
