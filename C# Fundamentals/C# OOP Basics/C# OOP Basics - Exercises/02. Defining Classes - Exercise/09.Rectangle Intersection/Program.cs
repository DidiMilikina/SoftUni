using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Rectangle_Intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            var numRect = int.Parse(input[0]);
            var intersectionCheks = int.Parse(input[1]);

            Dictionary<string, Rectangle> rectangles = new Dictionary<string, Rectangle>();

            for (int i = 0; i < numRect; i++)
            {
                var date = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                Rectangle rectangle = new Rectangle(
                    date[0],
                    double.Parse(date[1]),
                    double.Parse(date[2]),
                    new double[] { double.Parse(date[3]), double.Parse(date[4]) }
                );

                rectangles[date[0]] = rectangle;
            }

            for (int i = 0; i < intersectionCheks; i++)
            {
                var ids = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (rectangles.ContainsKey(ids[0]) && rectangles.ContainsKey(ids[1]))
                {
                    Console.WriteLine(Rectangle.DoTheyIntersect(rectangles[ids[0]], rectangles[ids[1]]).ToString().ToLower());
                }
            }
        }
    }
}
