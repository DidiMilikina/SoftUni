using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingExercise_Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()) - 1;
            string currentDirection = Console.ReadLine();

            while (currentDirection != "exit")
            {
                switch (currentDirection)
                {
                    case "left":
                        Left(n);
                        break;
                    case "right":
                        Right(n);
                        break;
                    case "up":
                        Up(n);
                        break;
                    case "down":
                        Down(n);
                        break;
                }
                currentDirection = Console.ReadLine();
            }
        }
        static void Left(int n)
        {
            for (int i = 0; i < n + 1; i++)
            {
                Console.WriteLine('*');
            }
        }
        static void Right(int n)
        {

        }
        static void Up(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', n));
                Console.Write(new string('*', n));
                Console.WriteLine(new string('.', n));
            }
        }
        static void Down(int n)
        {
            for (int i = 0;  i < 2 * n; i++)
            {
                Console.WriteLine('*');
            }
        }
    }
}

