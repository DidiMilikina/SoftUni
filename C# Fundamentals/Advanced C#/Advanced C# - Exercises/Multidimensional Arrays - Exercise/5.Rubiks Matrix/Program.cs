using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Rubiks_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var rows = dimensions[0];
            var cols = dimensions[1];

            var matrix = new int[rows][];
            var count = 1;
            for (int rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                matrix[rowIndex] = new int[cols];
                for (int colIndex = 0; colIndex < cols; colIndex++)
                {
                    matrix[rowIndex][colIndex] = count;
                    count++;
                }
            }

            var commandsNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsNum; i++)
            {
                var commandToken = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var rowColIndex = int.Parse(commandToken[0]);
                var directions = commandToken[1];
                var moves = int.Parse(commandToken[2]);

                switch (directions)
                {
                    case "up":
                        MoveCol(matrix, rowColIndex, moves);
                        break;
                    case "down":
                        MoveCol(matrix, rowColIndex, rows - moves % rows);
                        break;
                    case "left":
                        MoveRow(matrix, rowColIndex, moves);
                        break;
                    case "right":
                        MoveRow(matrix, rowColIndex, cols - moves % cols);
                        break;
                }
            }

            var element = 1;
            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                for (int colIndex = 0; colIndex < matrix[0].Length; colIndex++)
                {
                    if (matrix[rowIndex][colIndex] == element)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        for (int i = 0; i < matrix.Length; i++)
                        {
                            for (int j = 0; j < matrix[0].Length; j++)
                            {
                                if (matrix[i][j] == element)
                                {
                                    var currentEl = matrix[rowIndex][colIndex];
                                    matrix[rowIndex][colIndex] = element;
                                    matrix[i][j] = currentEl;
                                    Console.WriteLine($"Swap ({rowIndex}, {colIndex}) with ({i}, {j})");
                                    break;
                                }
                            }
                        }
                    }
                    element++;
                }
            }
        }

        private static void MoveRow(int[][] matrix, int rowColIndex, int moves)
        {
            var temp = new int[matrix[0].Length];
            for (int colIndex = 0; colIndex < matrix[0].Length; colIndex++)
            {
                temp[colIndex] = matrix[rowColIndex][(colIndex + moves) % matrix[0].Length];
            }
            matrix[rowColIndex] = temp;
        }

        private static void MoveCol(int[][] matrix, int rowColIndex, int moves)
        {
            var temp = new int[matrix.Length];
            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                temp[rowIndex] = matrix[(rowIndex + moves) % matrix.Length][rowColIndex];
            }
            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                matrix[rowIndex][rowColIndex] = temp[rowIndex];
            }
        }
    }
}
