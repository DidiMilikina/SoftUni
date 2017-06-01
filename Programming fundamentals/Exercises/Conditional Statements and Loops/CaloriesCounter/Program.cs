using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());


            int counterCalories = 0;
            int cheeseCal = 500;
            int tomatoSauceCal = 150;
            int salamiCal = 600;
            int pepperCal = 50;

            for (int i = 0; i < number; i++)
            {

                string ingredients = Console.ReadLine().ToLower();
                if (ingredients.Length <= 50)
                {
                    if (ingredients == "cheese")
                    {
                        counterCalories += cheeseCal;
                    }
                    else if (ingredients == "tomato sauce")
                    {
                        counterCalories += tomatoSauceCal;
                    }
                    else if (ingredients == "salami")
                    {
                        counterCalories += salamiCal;
                    }
                    else if (ingredients == "pepper")
                    {
                        counterCalories += pepperCal;
                    }
                }
            }

            Console.WriteLine($"Total calories: {counterCalories}");  
        } 
      }
            
}

