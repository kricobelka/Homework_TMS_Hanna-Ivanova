using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementationOfTaxiApp
{
    internal class Motorbike : Vehicle, ITaxi
    {
        public Motorbike(string statenumber, double fuelconsumption, double maxSpeed, double acceleration, string brand) 
            : base(statenumber, fuelconsumption)
        {
            MaxSpeed = maxSpeed;
            Acceleration = acceleration;
            Brand = brand;
        }
        public double MaxSpeed { get; set; }

        public double Acceleration { get; set; }

        public string Brand { get; }

        public double GetPriceOfRide()
        {
            return 19.7d;
        }

        public void MakeRide(User user)
        {
            Console.WriteLine($"The request for ride is accepted.");
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append($"\nMotorbike:\n Statenumber: {StateNumber}\n FuelCOnsumption: {FuelConsumption}\n Brand: {Brand}\n Acceleration:{Acceleration}\n MaxSpeed: {MaxSpeed}");
            stringBuilder.Append ($"\nPrice of ride is {GetPriceOfRide()}.");
            return stringBuilder.ToString();
        }
    }
}
