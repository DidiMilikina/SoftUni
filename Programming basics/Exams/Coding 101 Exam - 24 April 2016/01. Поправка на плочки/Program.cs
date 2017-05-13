using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Поправка_на_плочки
{
    class Program
    {
        static void Main(string[] args)
        {
            var sideOfPlayground = double.Parse(Console.ReadLine());
            var widthOfPlate = double.Parse(Console.ReadLine());
            var lenghtOfPlate = double.Parse(Console.ReadLine());
            var widthOfBench = double.Parse(Console.ReadLine());
            var lenghtOfBench = double.Parse(Console.ReadLine());

            var areaOfPlayground = sideOfPlayground * sideOfPlayground;
            var areaOfBench = widthOfBench * lenghtOfBench;
            areaOfPlayground = areaOfPlayground - areaOfBench;
            var areaOfPlate = widthOfPlate * lenghtOfPlate;
            var countOfPlates = areaOfPlayground / areaOfPlate;
            var neededTime = countOfPlates * 0.2;
            Console.WriteLine(countOfPlates);
            Console.WriteLine(neededTime);
        }
    }
}
