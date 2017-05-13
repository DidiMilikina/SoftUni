using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine().ToLower();
            var dayOfWeek = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());
            var price = -1.0;

            if (dayOfWeek == "saturday" || dayOfWeek == "sunday")
            {
                 if (fruit == "banana") price = 2.7;
               
                else if (fruit == "apple") price = 1.25;
                    else if (fruit == "orange") price = 0.9;
                    else if (fruit == "grapefruit") price = 1.6;
                    else if (fruit == "kiwi") price = 3.00;
                    else if (fruit == "pineapple") price = 5.6;
                    else if (fruit == "grapes") price = 4.2;
           

            }
            else if (dayOfWeek == "monday" || dayOfWeek == "tuesday" || dayOfWeek == "wednesday" || dayOfWeek == "thursday" || dayOfWeek == "friday")
            {
                if (fruit == "banana") price = 2.5;
                else if (fruit == "apple") price = 1.2;
               else if (fruit == "orange") price = 0.85;
               else if (fruit == "grapefruit") price = 1.45;
                else if (fruit == "kiwi") price = 2.7;
                else if (fruit == "pineapple") price = 5.5;
                else if (fruit == "grapes") price = 3.85;

            }
            if (price > 0)
                Console.WriteLine("{0:f2}", price * quantity);
            else
                Console.WriteLine("error");
        }
        }
    }