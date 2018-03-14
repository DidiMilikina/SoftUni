using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Car : Vehicle
{
    private const double AcConsumptionMod = 0.9;

    public Car(double fuelQuantity, double fuelConsumptionPerKm) 
        :base(fuelQuantity, fuelConsumptionPerKm + AcConsumptionMod)
    {
    }

    protected override double FuelQuantity
    {
        set
        {
            if (value > this.Capacity)
            {
                throw new ArgumentException("Cannot fit in tank");
            }
            base.FuelQuantity = value;
        }
    }
}

