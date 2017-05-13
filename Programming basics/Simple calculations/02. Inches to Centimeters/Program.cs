using System;

namespace _02.Inches_to_Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            var inches = double.Parse(Console.ReadLine());
            var centimeters = inches * 2.54;
            Console.Write("Centimeters = ");

            Console.WriteLine(centimeters);


        }
    }
}
