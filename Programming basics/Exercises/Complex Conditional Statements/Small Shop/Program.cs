using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            string cityName = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());

            if (productName == "coffee")
            {
                if (cityName == "Sofia")
                {
                    Console.WriteLine(quantity * 0.5);
                }
                else if (cityName == "Varna")
                {
                    Console.WriteLine(quantity * 0.45);
                }
                else if (cityName == "Plovdiv")
                {
                    Console.WriteLine(quantity * 0.4);
                }
            }
            else if (productName == "water")
            {
                if (cityName == "Sofia")
                {
                    Console.WriteLine(quantity * 0.8);
                }
                else if (cityName == "Varna")
                {
                    Console.WriteLine(quantity * 0.7);
                }
                else if (cityName == "Plovdiv")
                {
                    Console.WriteLine(quantity * 0.7);
                }
            } 
            else if ( productName == "beer")
            {
                if (cityName == "Sofia")
                {
                    Console.WriteLine(quantity * 1.2);
                }
                else if (cityName == "Varna")
                {
                    Console.WriteLine(quantity * 1.10);
                }
                else if (cityName == "Plovdiv")
                {
                    Console.WriteLine(quantity * 1.15);
                }
            }
            else if (productName == "sweets")
            {
                if (cityName == "Sofia")
                {
                    Console.WriteLine(quantity * 1.45);
                }
                else if (cityName == "Varna")
                {
                    Console.WriteLine(quantity * 1.35);
                }
                else if (cityName == "Plovdiv")
                {
                    Console.WriteLine(quantity * 1.3);
                }
            }
            else if (productName == "peanuts")
            {
                if (cityName == "Sofia")
                {
                    Console.WriteLine(quantity * 1.6);
                }
                else if (cityName == "Varna")
                {
                    Console.WriteLine(quantity * 1.55);
                }
                else if (cityName == "Plovdiv")
                {
                    Console.WriteLine(quantity * 1.5);
                }
            }
        }
    }
}
