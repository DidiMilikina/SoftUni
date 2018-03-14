using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Raw_Data
{
    public class Cargo
    {
        public string cargoType;
        public int cargoWeight;

        public Cargo(string cargoType, int cargoWeight)
        {
            this.cargoType = cargoType;
            this.cargoWeight = cargoWeight;
        }
    }
}
