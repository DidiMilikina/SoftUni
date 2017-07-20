using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    class Boxes
    {
        class Box
        {
            public int UpperLeft { get; set; }
            public int UpperRight { get; set; }
            public int BottomLeft { get; set; }
            public int BottomRight { get; set; }

            public static int Height(int UpperLeft, int BottomLeft)
            {
                var height = Math.Abs(UpperLeft - BottomLeft);
                return height;
            }

            public static int Width(int UpperLeft, int UpperRight)
            {
                var width = Math.Abs(UpperLeft - UpperRight);
                return width;
            }
            public static int CalculatePerimeter(double width, double height)
            {
                return (int)((2 * width) + (2 * height));
            }
            public static int CalculateArea(double width, double height)
            {
                return (int)(width * height);
            }
        }
        static void Main(string[] args)
        {
            var boxes = new List<Box>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                var inputParams = input
                    .Split(new char[] {' ', ':', '|'},
                    StringSplitOptions.RemoveEmptyEntries); 
                
                var currentBox = new Box
                {
                    UpperLeft = int.Parse(inputParams[0]),
                    UpperRight = int.Parse(inputParams[1]),
                    BottomLeft = int.Parse(inputParams[2]),
                    BottomRight = int.Parse(inputParams[3])
                };
                boxes.Add(currentBox);

                input = Console.ReadLine();
            }

            foreach (var box in boxes)
            {
                var width = Box.Width(box.UpperLeft, box.UpperRight);
                var height = Box.Height(box.BottomLeft, box.BottomRight);
                Console.WriteLine($"Box: {width}, {height}");
                Console.WriteLine($"Perimeter: {Box.CalculatePerimeter(width, height)}");
                Console.WriteLine($"Area: {Box.CalculateArea(width, height)}");
            }
        }
    }
}
