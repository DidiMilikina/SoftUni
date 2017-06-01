using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string typeOfPackage = Console.ReadLine();
            
            if(groupSize <= 50)
            {
                double price = 2500;
                if(typeOfPackage == "Normal")
                {
                    double priceNormal = 500;
                    double totalPrice = price + priceNormal;
                    double discount = totalPrice * 0.95;
                    double pricePerPerson = discount / groupSize;
                    Console.WriteLine($"We can offer you the {"Small Hall"}");
                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                }
                else if(typeOfPackage == "Gold")
                {
                    double priceNormal = 750;
                    double totalPrice = price + priceNormal;
                    double discount = totalPrice * 0.9;
                    double pricePerPerson = discount / groupSize;
                    Console.WriteLine($"We can offer you the {"Small Hall"}");
                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                }
                else
                {
                    double priceNormal = 1000;
                    double totalPrice = price + priceNormal;
                    double discount = totalPrice * 0.85;
                    double pricePerPerson = discount / groupSize;
                    Console.WriteLine($"We can offer you the {"Small Hall"}");
                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                }
            }
            else if(groupSize > 50 && groupSize <= 100)
            {
                double price = 5000;
                if (typeOfPackage == "Normal")
                {
                    double priceNormal = 500;
                    double totalPrice = price + priceNormal;
                    double discount = totalPrice * 0.95;
                    double pricePerPerson = discount / groupSize;
                    Console.WriteLine($"We can offer you the {"Terrace"}");
                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                }
                else if (typeOfPackage == "Gold")
                {
                    double priceNormal = 750;
                    double totalPrice = price + priceNormal;
                    double discount = totalPrice * 0.9;
                    double pricePerPerson = discount / groupSize;
                    Console.WriteLine($"We can offer you the {"Terrace"}");
                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                }
                else
                {
                    double priceNormal = 1000;
                    double totalPrice = price + priceNormal;
                    double discount = totalPrice * 0.85;
                    double pricePerPerson = discount / groupSize;
                    Console.WriteLine($"We can offer you the {"Terrace"}");
                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                }
            }
            else if(groupSize > 100 && groupSize <= 120)
            {
                double price = 7500;
                if (typeOfPackage == "Normal")
                {
                    double priceNormal = 500;
                    double totalPrice = price + priceNormal;
                    double discount = totalPrice * 0.95;
                    double pricePerPerson = discount / groupSize;
                    Console.WriteLine($"We can offer you the {"Great Hall"}");
                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                }
                else if (typeOfPackage == "Gold")
                {
                    double priceNormal = 750;
                    double totalPrice = price + priceNormal;
                    double discount = totalPrice * 0.9;
                    double pricePerPerson = discount / groupSize;
                    Console.WriteLine($"We can offer you the {"Great Hall"}");
                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                }
                else
                {
                    double priceNormal = 1000;
                    double totalPrice = price + priceNormal;
                    double discount = totalPrice * 0.85;
                    double pricePerPerson = discount / groupSize;
                    Console.WriteLine($"We can offer you the {"Great Hall"}");
                    Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                }
            }
            else
            {
                Console.WriteLine($"We do not have an appropriate hall.");
            }
               
            }
        }
    }

