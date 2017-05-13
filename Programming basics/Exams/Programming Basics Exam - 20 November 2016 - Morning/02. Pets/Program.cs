using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pets
{
    class Program
    {
        static void Main(string[] args)

        {
            var days = double.Parse(Console.ReadLine());
            var foodAvailable = double.Parse(Console.ReadLine());
            var foodForDog = double.Parse(Console.ReadLine());
            var foodForCat = double.Parse(Console.ReadLine());
            var foodForTurtle = double.Parse(Console.ReadLine()) / 1000;

            var neededFoodForDog = days * foodForDog;
            var neededFoodForCat = days * foodForCat;
            var neededFoodForTurtle = days * foodForTurtle;
            var neededFood = neededFoodForDog + neededFoodForCat + neededFoodForTurtle;

            if (neededFood <= foodAvailable)
            {
                
                Console.WriteLine("{0} kilos of food left.", Math.Floor(foodAvailable - neededFood));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(neededFood - foodAvailable));
            }

        }
    }
}
