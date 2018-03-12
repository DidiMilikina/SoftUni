using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                var rowNumber = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < cols - 1; j++)
                {
                    matrix[rows, cols] = int.Parse(rowNumber[j]);
                }
            }          
        }
    }
}
