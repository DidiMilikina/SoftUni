using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = int.Parse(Console.ReadLine());
            int[][] triangle = new int[height][];

            for (int currentHeight = 0; currentHeight < height; currentHeight++)
            {
                triangle[currentHeight] = new int[currentHeight + 1];
                triangle[currentHeight][0] = 1;
                triangle[currentHeight][currentHeight] = 1;

                if (currentHeight >= 2)
                {
                    for (int widthCounter = 1; widthCounter < currentHeight; widthCounter++)
                    {
                        triangle[currentHeight][widthCounter] =
                            triangle[currentHeight - 1][widthCounter - 1] +
                            triangle[currentHeight - 1][widthCounter];
                    }
                }
            }

            for (int rows = 0; rows < triangle.Length; rows++)
            {
                for (int cols = 0; cols < triangle[rows].Length; cols++)
                {
                    Console.Write(triangle[rows][cols] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
