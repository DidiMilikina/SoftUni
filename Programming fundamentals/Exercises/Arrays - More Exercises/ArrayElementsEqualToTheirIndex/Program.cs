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
                int[] elements = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

            for (int i = 0; i < elements.Length; i++)
            {
                if(elements[i] == i)
                {
                    Console.Write(elements[i] + " ");
                }
            }
            Console.WriteLine();
           }
        }
    }