using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01___Dog_House
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenghtPageA = double.Parse(Console.ReadLine());
            var hightHouseB = double.Parse(Console.ReadLine());

            var twoPages = lenghtPageA * (lenghtPageA / 2) * 2;
            var square = (lenghtPageA / 2) * (lenghtPageA / 2);
            var triangle = (lenghtPageA / 2) * (hightHouseB - lenghtPageA / 2) / 2;
            var backPage = square + triangle;
            var entrance = ((lenghtPageA / 5) * (lenghtPageA / 5));
            var frontWall = backPage - entrance;
            var totalAreaOfWalls = twoPages + backPage + frontWall;
            var greenPaint = totalAreaOfWalls / 3;
            var roof = lenghtPageA * (lenghtPageA / 2) * 2;
            var redPaint = roof / 5;
            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");
        }
    }
}
