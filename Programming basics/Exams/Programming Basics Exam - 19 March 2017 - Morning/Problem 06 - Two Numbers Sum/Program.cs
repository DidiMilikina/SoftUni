using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_06___Two_Numbers_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            var beggining = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var magicNum = int.Parse(Console.ReadLine());
            var counter = 0;

            for (int i = beggining; i >= end; i--)
            {
                var sum = 0;
                for (int j = beggining; j >= end; j--)
                {
                    counter++;
                    sum = i + j;
                    if (sum == magicNum)
                    {
                        Console.Write($"Combination N:{counter} ");
                        Console.WriteLine($"({i} + {j} = {magicNum})");
                        return;
                    }
                }
            }
                Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
            }
        }
    }
