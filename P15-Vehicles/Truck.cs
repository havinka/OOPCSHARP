using System;
namespace P15_Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {
        }

        public override string Refuel(double fuelAmount)
        {
            return base.Refuel(fuelAmount*0.95); 
        }
    }
}

