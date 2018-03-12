using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Pizza_Calories
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CalculatePizzaCalories();

            void CalculatePizzaCalories()
            {
                var inpit = Console.ReadLine().Split();

                try
                {
                    while (inpit[0] != "END")
                    {
                        switch (inpit[0].ToLower())
                        {
                            case "pizza":
                                var pizza = SetPizza(inpit[1], int.Parse(inpit[2]));
                                Console.WriteLine(pizza.GetTotalCalories());
                                break;
                            case "dough":
                                var douugh = new Dough(inpit[1], inpit[2], int.Parse(inpit[3]));
                                Console.WriteLine($"{douugh.GetCalories():F2}");
                                break;
                            case "topping":
                                var toppint = new Topping(inpit[1], int.Parse(inpit[2]));
                                Console.WriteLine($"{toppint.GetCalories():F2}");
                                break;
                        }

                        inpit = Console.ReadLine().Split();
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Pizza SetPizza(string name, int toppingsCount)
            {
                var doughTypeAndTechnique = Console.ReadLine().Split();

                var pizza = new Pizza(name, toppingsCount);
                pizza.Dough = new Dough(doughTypeAndTechnique[1], doughTypeAndTechnique[2], int.Parse(doughTypeAndTechnique[3]));

                for (int i = 0; i < toppingsCount; i++)
                {
                    var toppingData = Console.ReadLine().Split();
                    pizza.AddTopping(new Topping(toppingData[1], int.Parse(toppingData[2])));
                }

                return pizza;
            }
        }
    }
}
