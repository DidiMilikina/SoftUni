using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = Console.ReadLine()
                .Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries);

            int[][] matrix = new int[int.Parse(matrixSize[0])][];
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine()
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }
            int maxSum = 0;

            for (int row = 0; row < matrix.Length; row++)
            {
                maxSum += matrix[row].Sum();
            }

            Console.WriteLine(matrix.Length);
            Console.WriteLine(matrix[0].Length);
            Console.WriteLine(maxSum);
        }
    }
}
