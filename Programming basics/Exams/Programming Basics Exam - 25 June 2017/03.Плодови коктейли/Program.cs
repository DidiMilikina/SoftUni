using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Плодови_коктейли
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            double orderedCoctails = double.Parse(Console.ReadLine());

            double price = 0.0;
            
            if (fruit == "Watermelon")
            {
                if (size == "small")
                {
                    price = 2 * 56;
                }
                else
                {
                    price = 5 * 28.70;
                }
            }
            else if(fruit == "Mango")
            {
                if (size == "small")
                {
                    price = 2 * 36.66;
                }
                else
                {
                    price = 5 * 19.60;
                }
            }
            else if (fruit == "Pineapple")
            {
                if (size == "small")
                {
                    price = 2 * 42.10;
                }
                else
                {
                    price = 5 * 24.80;
                }
            }
            else 
            {
                if (size == "small")
                {
                    price = 2 * 20;
                }
                else
                {
                    price = 5 * 15.20;
                }
            }

            double sum = price * orderedCoctails;
            if (sum >= 400 && sum <= 1000)
            {
                sum *= 0.85;
            }
            else if (sum > 1000)
            {
                sum *= 0.5;
            }

            Console.WriteLine($"{sum:f2} lv.");
        }
    }
}