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
            public int UpperLeftX { get; set; }
            public int UpperLeftY { get; set; }
            public int UpperRightX { get; set; }
            public int UpperRightY { get; set; }
            public int LowerLeftX { get; set; }
            public int LowerLeftY { get; set; }
            public int LowerRightX { get; set; }
            public int LowerRightY { get; set; }

            public static int Height(int x1, int x2)
            {
                var height = Math.Abs(x1 - x2);
                return height;
            }

            public static int Width(int y1, int y2)
            {
                var width = Math.Abs(y1 - y2);
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
                    UpperLeftX = int.Parse(inputParams[0]),
                    UpperLeftY = int.Parse(inputParams[1]),
                    UpperRightX = int.Parse(inputParams[2]),
                    UpperRightY = int.Parse(inputParams[3]),
                    LowerLeftX = int.Parse(inputParams[4]),
                    LowerLeftY = int.Parse(inputParams[5]),
                    LowerRightX = int.Parse(inputParams[6]),
                    LowerRightY = int.Parse(inputParams[7])
                };
                boxes.Add(currentBox);

                input = Console.ReadLine();
            }

            foreach (var box in boxes)
            {
                var width = Box.Width(box.UpperLeftX, box.UpperRightX);
                var height = Box.Height(box.UpperLeftY, box.LowerLeftY);
                Console.WriteLine($"Box: {width}, {height}");
                Console.WriteLine($"Perimeter: {Box.CalculatePerimeter(width, height)}");
                Console.WriteLine($"Area: {Box.CalculateArea(width, height)}");
            }
        }
    }
}
