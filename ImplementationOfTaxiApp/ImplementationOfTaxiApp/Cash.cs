﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementationOfTaxiApp
{
    internal class Cash : IPaymentMethod
    {
        public Cash(double cashOnHand)
        {
            CashOnHand = cashOnHand;
        }

        public double CashOnHand { get; set; }
        
        public double AddMoney(double money)
        {
            CashOnHand += money;
            return CashOnHand;
        }

        public bool IsPaymentPossible(double money)
        {
            if (CashOnHand <= money || CashOnHand <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public double MakePayment(double money)
        {
            if (CashOnHand < money || CashOnHand <= 0)
            {
                Console.WriteLine($"Lack of {CashOnHand - money} cash");
                return 0;
            }
            else
            {
                CashOnHand -= money;
                return CashOnHand;
            }
        }
        public override string ToString()
        {
            return CashOnHand.ToString();
        }
    }
}
