using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Drawing_tool
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();

            if (figure.Equals("Square"))
            {
                Square.DrowSquare(int.Parse(Console.ReadLine()));
            }
            else
            {
                Rectangle.DrowRectangle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            }
        }
    }
}
