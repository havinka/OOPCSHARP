﻿using System;
namespace P15_Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption + 0.9)
        {
        }
    }
}

