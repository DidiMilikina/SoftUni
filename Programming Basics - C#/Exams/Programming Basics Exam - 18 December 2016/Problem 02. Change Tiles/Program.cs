using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_02.Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var recievedMoney = double.Parse(Console.ReadLine());
            var widthFloor = double.Parse(Console.ReadLine());
            var lenghtFloor = double.Parse(Console.ReadLine());
            var sideOfTriangle = double.Parse(Console.ReadLine());
            var heightOfTriangle = double.Parse(Console.ReadLine());
            var pricePerOneTile = double.Parse(Console.ReadLine());
            var moneyForWorkman = double.Parse(Console.ReadLine());

            var areaOfFloor = widthFloor * lenghtFloor;
            var areaOfTile = (sideOfTriangle * heightOfTriangle) / 2;

            var tiles = Math.Ceiling(areaOfFloor / areaOfTile); 
            var tilesWithRest = tiles + 5;
          
            var totalPrice = tilesWithRest * pricePerOneTile + moneyForWorkman;

            if (recievedMoney >= totalPrice)
            {
                Console.WriteLine($"{recievedMoney - totalPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"You'll need {totalPrice - recievedMoney:f2} lv more.");
            }
        }
    }
}
