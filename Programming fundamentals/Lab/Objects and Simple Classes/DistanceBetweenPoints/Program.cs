using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Point firstPoint = Point.ParsePoint(Console.ReadLine());
            Point secondPoint = Point.ParsePoint(Console.ReadLine());

            double distance = CalcDistance(firstPoint, secondPoint);

            Console.WriteLine("{0:F3}", distance);
        }

        private static double CalcDistance(Point firstPoint, Point secondPoint)
        {
            double sideA = Math.Pow((firstPoint.X - secondPoint.X), 2);
            double sideB = Math.Pow((firstPoint.Y - secondPoint.Y), 2);


            return Math.Sqrt(sideA + sideB);
        }
    }
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int xCoord, int yCoord)
        {
            X = xCoord;
            Y = yCoord;
        }

        public static Point ParsePoint(string input)
        {
            int[] inputData = input.Split(' ').Select(int.Parse).ToArray();

            return new Point(inputData[0], inputData[1]);
        }
    }
}