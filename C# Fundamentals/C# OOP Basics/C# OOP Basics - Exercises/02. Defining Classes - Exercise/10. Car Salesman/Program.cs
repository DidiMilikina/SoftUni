using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Car_Salesman
{
    class Program
    {
        static void Main(string[] args)
        {
            var linesOfEngines = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < linesOfEngines; i++)
            {
                var tokens = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string engineModel = tokens[0];
                string enginePower = tokens[1];

                if (tokens.Length == 2)
                {
                    engines.Add(new Engine(engineModel, enginePower));
                }
                else if (tokens.Length == 3)
                {
                    int engineDisplacement;
                    bool isDisplacement = int.TryParse(tokens[2], out engineDisplacement);
                    if (isDisplacement)
                    {
                        engines.Add(new Engine(engineModel, enginePower, engineDisplacement));
                    }
                    else
                    {
                        string engineEfficiency = tokens[2];
                        engines.Add(new Engine(engineModel, enginePower, engineEfficiency));
                    }
                }
                else if (tokens.Length == 4)
                {
                    int engineDisplacement = int.Parse(tokens[2]);
                    string engineEfficiency = tokens[3];
                    engines.Add(new Engine(engineModel, enginePower, engineDisplacement, engineEfficiency));
                }
            }

            int carsCount = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < carsCount; i++)
            {
                var tokens = Console.ReadLine()
                    .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                var carModel = tokens[0];
                var carEngine = tokens[1];

                Engine engine = new Engine(null, null);

                foreach (Engine eng in engines)
                {
                    if (eng.engineModel == carEngine)
                    {
                        engine = eng;
                    }
                }

                if (tokens.Length == 2)
                {
                    cars.Add(new Car(carModel, engine));
                }
                else if (tokens.Length == 3)
                {
                    int carWeight;
                    bool isWeight = int.TryParse(tokens[2], out carWeight);
                    if (isWeight)
                    {
                        cars.Add(new Car(carModel, engine, carWeight));
                    }
                    else
                    {
                        string carColor = tokens[2];
                        cars.Add(new Car(carModel, engine, carColor));
                    }
                }
                else if (tokens.Length == 4)
                {
                    int carWeight = int.Parse(tokens[2]);
                    string carColor = tokens[3];
                    cars.Add(new Car(carModel, engine, carWeight, carColor));
                }
            }

            foreach (Car car in cars)
            {
                Console.WriteLine("{0}:", car.carModel);
                Console.WriteLine("  {0}:", car.carEngine.engineModel);
                Console.WriteLine("    Power: {0}", car.carEngine.enginePower);
                Console.WriteLine("    Displacement: {0}", car.carEngine.engineDisplacement == 0 ? "n/a" : car.carEngine.engineDisplacement.ToString());
                Console.WriteLine("    Efficiency: {0}", car.carEngine.engineEfficiency);
                Console.WriteLine("  Weight: {0}", car.carWeight == 0 ? "n/a" : car.carWeight.ToString());
                Console.WriteLine("  Color: {0}", car.carColor);
            }
        }
    }
}
