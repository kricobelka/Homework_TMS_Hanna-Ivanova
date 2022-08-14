using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementationOfTaxiApp
{
    internal class Car : Vehicle, ITaxi
    {
        public Car(string statenumber, double fuelconsumption, string brand, string color, double maxSpeed)
            : base(statenumber, fuelconsumption)
        {
            Brand = brand;
            Color = color;
            MaxSpeed = maxSpeed;
        }
        public string Brand { get; }

        public string Color { get; set; }

        public double MaxSpeed { get; set; }

        public override string ToString()
        {
            //StringBuilder stringBuilder = new StringBuilder();

            return "1. Car:" + StateNumber + " " + FuelConsumption + " " + Brand + " " + Color + " " + MaxSpeed;
        }
    }
}
