using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementationOfTaxiApp
{
    internal interface ITaxi
    {
        public void MakeRide (User user)
        {
            Console.WriteLine($"{user.Username}, {user.Surname}\n used");
        }
        public double GetPriceOfRide ()
        {
            return 14.5d;
        }
    }
}
