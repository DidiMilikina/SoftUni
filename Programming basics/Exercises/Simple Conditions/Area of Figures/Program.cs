using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Figure: ");
            string figure = Console.ReadLine();
            if (figure == "square")
            {
                Console.Write("Enter length: ");
                double lenght = double.Parse(Console.ReadLine());
                Console.WriteLine("Square area = " + (Math.Round(lenght * lenght, 3)));
            }
            if (figure == "rectangle")
            {
                Console.Write("Enter length: ");
                double lenght = double.Parse(Console.ReadLine());
                Console.Write("Enter width: ");
                double width = double.Parse(Console.ReadLine());
                Console.WriteLine("Rectangle area = " + (Math.Round(lenght * width, 3)));
            }
            if (figure == "circle")
            {
                Console.Write("Enter radius: ");
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine("Circle area = " + (Math.Round(Math.PI * radius * radius, 3)));
            }
            if (figure == "triangle")
            {
                Console.Write("Enter length: ");
                double TriangleLenght = double.Parse(Console.ReadLine());
                Console.Write("Enter height: ");
                double Triangleheight = double.Parse(Console.ReadLine());
                Console.WriteLine("Triangle area = " + (Math.Round(((TriangleLenght * Triangleheight) / 2), 3)));
            }
        }
    }
}
