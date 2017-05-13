using System;


namespace Square_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var sideOfSquare = int.Parse(Console.ReadLine());
            var areaOfSquare = sideOfSquare * sideOfSquare;
            Console.WriteLine(areaOfSquare);


        }
    }
}
