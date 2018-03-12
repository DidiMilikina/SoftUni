using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Group_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None)
                .Select(int.Parse).ToArray();
            var sizes = new int[3];

            foreach (int number in numbers)
            {
                sizes[Math.Abs(number % 3)]++;
            }

            int[][] jaggedArray = new int[3][];
            for (int counter = 0; counter < sizes.Length; counter++)
            {
                jaggedArray[counter] = new int[sizes[counter]];
            }

            int[] index = new int[3];
            foreach (var number in numbers)
            {
                var reminder = Math.Abs(number % 3);
                jaggedArray[reminder][index[reminder]] = number;
                index[reminder]++;
            }

            for (int rows = 0; rows < jaggedArray.Length; rows++)
            {
                for (int cols = 0; cols < jaggedArray[rows].Length; cols++)
                {
                    Console.Write(jaggedArray[rows][cols] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
