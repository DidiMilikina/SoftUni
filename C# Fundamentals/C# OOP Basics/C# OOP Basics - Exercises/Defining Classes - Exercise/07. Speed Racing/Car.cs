using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Speed_Racing
{
    class Car
    {
        public string carModel;
        public decimal fuelAmmount;
        public decimal fuelCost;
        public decimal distanceTravelled;


        public Car(string carModel, decimal fuelAmmount, decimal fuelCost)
        {
            this.carModel = carModel;
            this.fuelAmmount = fuelAmmount;
            this.fuelCost = fuelCost;
        }

        public void DriveInfo(decimal distance)
        {
            if (this.fuelAmmount < distance * this.fuelCost)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.fuelAmmount -= distance * this.fuelCost;
                this.distanceTravelled += distance;
            }
        }
    }
}
