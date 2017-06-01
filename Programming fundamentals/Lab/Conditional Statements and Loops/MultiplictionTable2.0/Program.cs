using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplictionTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());

            Console.WriteLine($"{number} X {times} = {number * times}");
            for (int i = times + 1; i <= 10; i++)
            {
                    int sum = number * i;
                    Console.WriteLine($"{number} X {i} = {sum}");
            }

        }
    }
}
