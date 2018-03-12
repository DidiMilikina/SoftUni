using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            var beggining = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var maxCombinations = int.Parse(Console.ReadLine());

            var counter = 0;
            for (int i = beggining; i <= end; i++)
            {
                for (int j = beggining; j <= end; j++)
                {
                    if(counter == maxCombinations)
                    {
                        break;
                    }
                   
                    Console.Write($"<{i}-{j}>");
                    counter++;
                }

            }
        }
    }
}
