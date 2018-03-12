using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int cars = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            Queue<string> carsQueue = new Queue<string>();
            int totalPassedCars = 0;

            while (input != "end")
            {
                if (input == "green")
                {
                    int carsPassed = Math.Min(carsQueue.Count, cars);
                    for (int countIndex = 0; countIndex < carsPassed; countIndex++)
                    {
                        Console.WriteLine($"{carsQueue.Dequeue()} passed!");
                        totalPassedCars++;
                    }
                }
                else
                {
                    carsQueue.Enqueue(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{totalPassedCars} cars passed the crossroads.");
        }
    }
}
