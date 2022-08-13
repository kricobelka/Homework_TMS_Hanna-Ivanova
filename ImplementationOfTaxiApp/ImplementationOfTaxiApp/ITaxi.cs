using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementationOfTaxiApp
{
    internal interface ITaxi
    {
        public void MakeRide (User user)
        {
            Console.WriteLine($"{username}, {surname}\n used");
        }
        public static double GetPriceOfRide ()
        {
            return 14.5;
        }
    }
}
