using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Зеленчукова_борса
{
    class Program
    {
        static void Main(string[] args)
        {
            var vegetables = double.Parse(Console.ReadLine());
            var fruits = double.Parse(Console.ReadLine());
            var veg = int.Parse(Console.ReadLine());
            var fr = int.Parse(Console.ReadLine());

            var numberOfVegetables = vegetables * veg;
            var numberOfFruits = fruits * fr;

            Console.WriteLine(numberOfVegetables);
            Console.WriteLine(numberOfFruits);
            var totalPrice = numberOfVegetables + numberOfFruits;
            Console.WriteLine(totalPrice / 1.94);

        }
    }
}
