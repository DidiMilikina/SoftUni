using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.House_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            double theSmallestRoom = double.Parse(Console.ReadLine());
            double kitchen = double.Parse(Console.ReadLine());
            double pricePerSquareMeter = double.Parse(Console.ReadLine());

            double secondRoom = (theSmallestRoom * 0.1) + theSmallestRoom;
            double thirdRoom = (secondRoom * 0.1) + secondRoom;
            double bathroom = theSmallestRoom / 2;
            double hall = (theSmallestRoom + bathroom + secondRoom + thirdRoom + kitchen) * 0.05;
            double area = theSmallestRoom + bathroom + secondRoom + thirdRoom + kitchen + hall;
            double price = pricePerSquareMeter * area;
            Console.WriteLine($"{price:f2}");
        }
    }
}
