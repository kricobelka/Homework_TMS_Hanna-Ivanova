using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementationOfTaxiApp
{
    internal interface ITaxi
    {
        public void MakeRide(User user);
        //{
        //    Console.WriteLine($"The request for ride is accepted.");
        //}
        public double GetPriceOfRide();
    }
}
