using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementationOfTaxiApp
{
    internal class Points : IPaymentMethod
    {
        //private double _pointsOnAccount;
        //public Points(double pointsOnAccount)
        //{
        //    PointsOnAccount = pointsOnAccount;
        //}
        //pointsonaccot initial = 0

        public double AmountofSum { get; set; }
        public double PointsOnAccount { get; set; }
        //public double PointsOnAccount
        //{
        //    get => _pointsOnAccount;
        //    set
        //    {
        //        _pointsOnAccount = value;
        //    }
        
        //get;set; - the same as expression abve?
        

        public bool IsPaymentPossible(double money)
        {
            if (PointsOnAccount < money / 3 || PointsOnAccount <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        // сначала пополняются деньги, а щатем делается персчет в баллы?
        public double AddMoney(double money)
        {
            AmountofSum += money;
            PointsOnAccount = AmountofSum / 3;
            return PointsOnAccount;
        }

        public double MakePayment(double Points)
        {
            if (PointsOnAccount <= 0 || PointsOnAccount < Points / 3)
            {
                Console.WriteLine("You dont have enough points to pay by points");
                return 0;
            }
            else
            {
                PointsOnAccount -= Points;
                AmountofSum -= Points * 3;
                return PointsOnAccount;
            }
        }

        public override string ToString()
        {
            return PointsOnAccount.ToString();
        }
    }
}
