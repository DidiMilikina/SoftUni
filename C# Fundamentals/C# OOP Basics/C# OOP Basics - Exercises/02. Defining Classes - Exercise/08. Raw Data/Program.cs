using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Raw_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Car[] cars = new Car[count];

            for (int i = 0; i < count; i++)
            {
                var tokens = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                string model = tokens[0];
                int engineSpeed = int.Parse(tokens[1]);
                int enginePower = int.Parse(tokens[2]);
                int cargoWeight = int.Parse(tokens[3]);
                string cargoType = tokens[4];
                double tire1Pressure = double.Parse(tokens[5]);
                int tire1Age = int.Parse(tokens[6]);
                double tire2Pressure = double.Parse(tokens[7]);
                int tire2Age = int.Parse(tokens[8]);
                double tire3Pressure = double.Parse(tokens[9]);
                int tire3Age = int.Parse(tokens[10]);
                double tire4Pressure = double.Parse(tokens[11]);
                int tire4Age = int.Parse(tokens[12]);

                cars[i] = new Car(model,
                    new Engine(engineSpeed, enginePower),
                    new Cargo(cargoType, cargoWeight),
                    new List<Tire>
                    {
                    new Tire(tire1Pressure, tire1Age),
                    new Tire(tire2Pressure, tire2Age),
                    new Tire(tire3Pressure, tire3Age),
                    new Tire(tire4Pressure, tire4Age)
                    });
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                cars.Where(c => c.engineCargo.cargoType == "fragile")
                    .Where(c => c.tires.Any(t => t.pressure < 1))
                    .Select(c => c.model)
                    .ToList()
                    .ForEach(m => Console.WriteLine(m));
            }
            else if (command == "flamable")
            {
                cars.Where(c => c.engineCargo.cargoType == "flamable")
                    .Where(c => c.engineSpeed.enginePower > 250)
                    .Select(c => c.model)
                    .ToList()
                    .ForEach(m => Console.WriteLine(m));
            }
        }
    }
}
