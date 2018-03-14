using System;

namespace _09.Rectangle_Intersection
{
    public class Rectangle
    {
        public string id;
        public double width;
        public double height;
        public double[] topLeft;


        public Rectangle(string id, double width, double height, double[] topLeft)
        {
            this.id = id;
            this.width = width;
            this.height = height;
            this.topLeft = new double[] { topLeft[0], topLeft[1] };
        }

        public static bool DoTheyIntersect(Rectangle rectangle1, Rectangle rectangle2)
        {
            bool doIntersect = false;

            if (Math.Abs(rectangle1.topLeft[0]) < Math.Abs(rectangle2.topLeft[0] + rectangle2.width))
            {
                if (Math.Abs(rectangle1.topLeft[0] + rectangle1.width) >= Math.Abs(rectangle2.topLeft[0]))
                {
                    if (rectangle1.topLeft[1] < Math.Abs(rectangle2.topLeft[1] - rectangle2.height))
                    {
                        if (Math.Abs(rectangle1.topLeft[1] + rectangle1.height) >= Math.Abs(rectangle2.topLeft[1]))
                        {
                            doIntersect = true;
                        }
                    }
                }
            }
            return doIntersect;
        }
    }
}