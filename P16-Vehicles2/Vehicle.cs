using System;
namespace P16_Vehicles2
{
    public abstract class Vehicle
    {
        private double fuelQuantity;

        public Vehicle(double fuelCapacity, double fuelQuantity, double fuelConsumption)
        {
            FuelCapacity = fuelCapacity;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;

        }

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set
            {
                if (value > FuelCapacity)
                {
                    throw new ArgumentException("Cannot fit fuel in tank");
                }
                fuelQuantity = value;
            }
        }

        public double FuelCapacity { get; set; }

        public virtual double FuelConsumption { get; set; }

        public string Drive(int km)
        {
            double neededFuel = km * FuelQuantity;
            if (neededFuel <= FuelQuantity)
            {
                FuelQuantity -= neededFuel;
                return $"{GetType().Name} travelled {km} km";
            }
            return $"{GetType().Name} needs refueling";
        }

        public virtual string Refuel(double fuelAmount)
        {
            FuelQuantity += fuelAmount;
            return $"{GetType().Name} refuel {fuelAmount} l, fuel quantity";
        }

        public override string ToString()
        {
            return $"{GetType().Name} fuel: {FuelQuantity} l, fuel consumption: {FuelConsumption} l/100";
        }
    }
}
