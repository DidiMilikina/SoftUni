using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Car_Salesman
{
    class Car
    {
        public string carModel;
        public Engine carEngine;
        public int carWeight;
        public string carColor;

        public Car(string carModel, Engine carEngine)
        {
            this.carModel = carModel;
            this.carEngine = carEngine;
            this.carWeight = 0;
            this.carColor = "n/a";
        }

        public Car(string carModel, Engine carEngine, int carWeight)
            : this(carModel, carEngine)
        {
            this.carWeight = carWeight;
        }

        public Car(string carModel, Engine carEngine, string carColor)
            : this(carModel, carEngine)
        {
            this.carColor = carColor;
        }

        public Car(string carModel, Engine carEngine, int carWeight, string carColor)
            : this(carModel, carEngine)
        {
            this.carWeight = carWeight;
            this.carColor = carColor;
        }
    }
}
