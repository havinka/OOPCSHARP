using System;
namespace P16_Vehicles2
{
    public class Bus : Vehicle
    {
        public Bus(double fuelCapacity, double fuelQuantity, double fuelConsumption) : base(fuelCapacity, fuelQuantity, fuelConsumption)
        {
        }

        public bool HasPassengers { get; set; }

        public override double FuelConsumption
        {
            get
            {
                if (HasPassengers)
                {
                    return base.FuelConsumption + 1.4;
                }
                return base.FuelConsumption;
            }
            set => base.FuelConsumption = value;
        }
    }
}

