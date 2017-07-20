using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosestTwoPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                Point currentPoint = Point.ParsePoint(Console.ReadLine());
                points.Add(currentPoint);
            }

            double minDistance = double.MaxValue;
            Point[] bestPoints = new Point[2];

            for (int prevPoint = 0; prevPoint < points.Count; prevPoint++)
            {
                for (int currentPoint = prevPoint + 1; currentPoint < points.Count; currentPoint++)
                {
                    double distance = CalcDistance(points[prevPoint], points[currentPoint]);

                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        bestPoints[0] = points[prevPoint];
                        bestPoints[1] = points[currentPoint];
                    }
                }
            }

            Console.WriteLine($"{minDistance:f3}");
            Console.WriteLine(bestPoints[0]);
            Console.WriteLine(bestPoints[1]);
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

        public override String ToString()
        {
            return String.Format($"({X}, {Y})");
        }
    }
}