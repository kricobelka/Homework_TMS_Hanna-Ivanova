using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementationOfTaxiApp
{
    internal class Vehicle
    {
        private readonly string _statenumber;
        private readonly double _fuelconsumption;

        public Vehicle(string statenumber, double fuelconsumption)
        {
            //то же самое что и с value
            _statenumber = statenumber;
            if (fuelconsumption <= 0)
            {
                _fuelconsumption = 0;
            }
            else
            {
                _fuelconsumption = fuelconsumption;
            }
        }
        public double FuelConsumption { get => _fuelconsumption; }
        // это то же самое что и public double FuelConsumption { get;}?
        //public string StateNumber { get; }
        public string StateNumber { get => _statenumber; }
    }
}
