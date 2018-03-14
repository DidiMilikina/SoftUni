using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Speed_Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            var numCars = int.Parse(Console.ReadLine());
            Car[] cars = new Car[numCars];

            for (int i = 0; i < numCars; i++)
            {
                var tokens = Console.ReadLine()
                    .Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);

                var carModel = tokens[0];
                decimal fuelAmmount = decimal.Parse(tokens[1]);
                decimal fuelCost = decimal.Parse(tokens[2]);

                cars[i] = new Car(carModel, fuelAmmount, fuelCost);
            }
        }
    }
}
