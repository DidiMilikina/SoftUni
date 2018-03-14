using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            var sizeOfMatrix = int.Parse(Console.ReadLine());

            long[][] matrix = new long[sizeOfMatrix][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse).ToArray();
            }

            long primaryDiagonal = 0;
            long secondDiagonal = 0;

            for (int i = 0; i < sizeOfMatrix; i++)
            {
                primaryDiagonal += matrix[i][i];
            }
            for (int i = 0; i < sizeOfMatrix; i++)
            {
                secondDiagonal += matrix[i][matrix[i].Length - 1 - i];
            }

            Console.WriteLine(Math.Abs(primaryDiagonal - secondDiagonal));
        }
    }
}
