using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            long rows = input[0];
            long cols = input[1];

            if (input.Length < 2)
            {
                Console.WriteLine(0);
            }
            else
            {
                long counter = 0;
                var matrix = new char[rows][];
                for (int i = 0; i < rows; i++)
                {
                    matrix[i] = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                }
                for (int i = 0; i < rows - 1; i++)
                {
                    for (int j = 0; j < cols - 1; j++)
                    {
                        if (matrix[i][j] == matrix[i][j + 1] && matrix[i][j] == matrix[i + 1][j]
                            && matrix[i][j] == matrix[i + 1][j + 1])
                        {
                            counter++;
                        }
                    }
                }
                Console.WriteLine(counter);
            }
        }
    }
}
