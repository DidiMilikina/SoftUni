using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int count = 0;
            for (int i = 0; i < 20; i++)
            {
                string ingredients = Console.ReadLine();
                if (ingredients.Length <= 50)
                {
                    if (ingredients != "Bake!")
                    {
                        Console.WriteLine($"Adding ingredient {ingredients}.");
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
           Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}
