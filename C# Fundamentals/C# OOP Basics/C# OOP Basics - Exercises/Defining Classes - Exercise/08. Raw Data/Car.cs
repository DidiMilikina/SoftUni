using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Raw_Data
{
    class Car
    {
        public string model;
        public Engine engineSpeed;
        public Cargo engineCargo;
        public List<Tire> tires;

        public Car(string model, Engine engineSpeed, Cargo engineCargo, List<Tire> tires)
        {
            this.model = model;
            this.engineSpeed = engineSpeed;
            this.engineCargo = engineCargo;
            this.tires = tires;
        }
    }
}
