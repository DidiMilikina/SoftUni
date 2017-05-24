using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energyContent = double.Parse(Console.ReadLine());
            double sugarContent =double.Parse(Console.ReadLine());

            double volumeMultiplier = volume / 100;

            Console.Write($"{volume}ml ");
            Console.WriteLine($"{name}: ");
            Console.Write($"{energyContent * volumeMultiplier}kcal, ");
            Console.WriteLine($"{sugarContent * volumeMultiplier}g sugars");
        }
    }
}
