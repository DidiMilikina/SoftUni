using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_01___House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            var highOfHouse = double.Parse(Console.ReadLine());
            var lenghtOfLateralWall = double.Parse(Console.ReadLine());
            var highOfTriangleWallRoof = double.Parse(Console.ReadLine());

            #region wall

            var lateralWall = highOfHouse * lenghtOfLateralWall;
            var window = 1.5 * 1.5;
            var twoWalls = 2 * lateralWall - 2 * window;
            var rearWall = highOfHouse * highOfHouse;
            var entrance = 1.2 * 2;
            var rearWallAndEntrance = 2 * rearWall - entrance;
            var totalAreaWall = twoWalls + rearWallAndEntrance;
            var greenPaint = totalAreaWall / 3.4;
            Console.WriteLine($"{greenPaint:f2}");
            #endregion

            #region roof

            var twoReactangles = 2 * (highOfHouse * lenghtOfLateralWall);
            var twoTriangles = 2 * (highOfHouse * highOfTriangleWallRoof / 2);
            var totalAreaRoof = twoReactangles + twoTriangles;
            var redPaint = totalAreaRoof / 4.3;
            Console.WriteLine($"{redPaint:f2}");
            #endregion
        }
    }
}
