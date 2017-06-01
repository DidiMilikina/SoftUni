using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int sum = 0;
            int combinations = 0;
            int firstNumber = 0;
            int secondNumber = 0;
            bool combinationFound = false;
            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    sum = i + j;
                   
                    combinations++;
                    if(magicNum == sum)
                    {
                        combinationFound = true;
                        firstNumber = i;
                        secondNumber = j;
                    }
                }
            }

            if (combinationFound)
            {
                Console.WriteLine($"Number found! {firstNumber} + {secondNumber} = {magicNum}");
            }
            else
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNum}");
            }
        }
    }
}
