using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Sqr_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrixSize = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            int[][] matrix = new int[int.Parse(matrixSize[0])][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine()
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            var maxSqrRow = 0;
            var maxSqrCol = 0;
            var maxSum = int.MinValue;

            for (int row = 0; row < matrix.Length - 1; row++)
            {
                for (int col = 0; col < matrix[row].Length - 1; col++)
                {
                    var currentSum = matrix[row][col] + matrix[row][col + 1]
                        + matrix[row + 1][col] + matrix[row + 1][col + 1];

                    if (maxSum < currentSum)
                    {
                        maxSum = currentSum;
                        maxSqrRow = row;
                        maxSqrCol = col;
                    }
                }
            }
            Console.WriteLine($"{matrix[maxSqrRow][maxSqrCol]} {matrix[maxSqrRow][maxSqrCol + 1]}" +
                              $"\n{matrix[maxSqrRow + 1][maxSqrCol]} {matrix[maxSqrRow + 1][maxSqrCol + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}
