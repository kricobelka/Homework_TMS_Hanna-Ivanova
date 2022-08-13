using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementationOfTaxiApp
{
    internal interface IPaymentMethod
    {
        //public bool IsPaymentPossible(double money)
        //{
        //    Console.WriteLine ($"Please insert the sum you should pay");
        //    double value = int.Parse (Console.ReadLine());
        //    if (value < money)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}
        //if I realized the method above in the interface, is it necessary to write it in the covered classes?
        public bool IsPaymentPossible(double money);

        public double MakePayment(double money);

        public double AddMoney(double money);
        bool ContainsValue(string cardnumber);

        //public double Print();

    }
}
