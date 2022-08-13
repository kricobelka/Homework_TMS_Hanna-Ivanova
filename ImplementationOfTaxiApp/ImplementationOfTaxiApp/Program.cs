using System;
using System.Collections.Generic;

namespace ImplementationOfTaxiApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            User user = new User("Hanna", "Ivanova", "+375293833758", "Card", Card);
            Card card = new Card("6385 6342", 105.4d);
            Cash cash = new Cash(26.3d);
            Points points = new Points(0);

            Dictionary<IPaymentMethod, double> methods = new Dictionary<IPaymentMethod, double>();
            //{
            //    {Cash, null },
            //    {Card, "" },
            //    {Points,  }
            //};

        }
    }
}
