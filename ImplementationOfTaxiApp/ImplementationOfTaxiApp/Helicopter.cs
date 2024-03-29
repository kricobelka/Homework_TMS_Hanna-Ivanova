﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementationOfTaxiApp
{
    internal class Helicopter : Vehicle, ITaxi
    {
        private double _weight;

        public Helicopter(string statenumber, double fuelconsumption, string brand, double weight, double maxSpeed)
            : base(statenumber, fuelconsumption)
        {
            Brand = brand;
            Weight = weight;
            MaxSpeed = maxSpeed;
        }
        public string Brand { get; }
        public double Weight
        {
            get => _weight;

            set
            {
                if (value < 0)
                {
                    _weight = 0;
                }

                else
                {
                    _weight = value;
                }
            }
        }
        public double MaxSpeed { get; }

        public double GetPriceOfRide()
        {
            return 61.5d;
        }

        public void MakeRide(User user)
        {
            Console.WriteLine($"The request for ride is accepted.");
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append($"\nHelicopter: {StateNumber}, {FuelConsumption}, {Brand}, {Weight}, {MaxSpeed}");
            stringBuilder.Append($"\nPrice of ride is {GetPriceOfRide()}.");
            return stringBuilder.ToString();
        }
    }
}
