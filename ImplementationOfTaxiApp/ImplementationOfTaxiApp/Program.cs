using System;
using System.Collections.Generic;

namespace ImplementationOfTaxiApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Card card = new Card("6385 6342", 105.4d);
            //Cash cash = new Cash(26.3d);
            //Points points = new Points(0);

            //Dictionary<IPaymentMethod, double> paymentMethods = new Dictionary<IPaymentMethod, double>
            //{
            //    { "Cash", 0},
            //    {"Card", 0},
            //    {"Points",0}
            //};
            List<ITaxi> taxiTypes = new List<ITaxi>()
            {
                new Car("664AC",549.3d,"MAZDA", "black", 259.5d),
                new Helicopter("665TU", 5003.8d, "VERTAL", 208d, 1390.4d),
                new Motorbike("666CI", 560d, 304.7d, 7.0d, "YAMAHA"),
            };
            //как добавить параметры, если последним параметром является Dictionary?
            
            User user = new User("Hanna", "Ivanova", "+375293833758", 0);

        }
    }
}
