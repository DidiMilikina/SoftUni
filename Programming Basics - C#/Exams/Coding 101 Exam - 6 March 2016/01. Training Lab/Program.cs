using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var lenght = double.Parse(Console.ReadLine());

            var lenghtRoom = (lenght * 100) - 100;
            var seetRow = Math.Floor(lenghtRoom / 70);

            var widthRoom = width * 100;
            var seetNumber = Math.Floor(widthRoom / 120);
            var totalSeets = (seetRow * seetNumber) - 3;
            Console.WriteLine(totalSeets);
        }
    }
}