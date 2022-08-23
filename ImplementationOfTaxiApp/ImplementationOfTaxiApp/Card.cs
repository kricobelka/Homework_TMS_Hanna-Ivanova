using System;
using System.Collections.Generic;
using System.Text;


namespace ImplementationOfTaxiApp
{
    internal class Card : IPaymentMethod
    {
        private string _cardnumber;
        private double _amountOnCard;

        //public Card(double amountOnCard)
        //{
        //    AmountOnCard = amountOnCard;
        //}
        public double AmountOnCard { get; set; }
        public double CardNumber { get; set; }
        //модно и так:
        //public string CardNumber
        //{
        //    get
        //    {
        //        return _cardnumber;
        //    }
        //    set
        //    {

        //        _cardnumber = value;
        //    }
        //}
        //}если хотим чтоб на карте изначально была какая-то сумма:

        //public double AmountOnCard
        //{
        //    get => _amountOnCard;
        //    set => _amountOnCard = value + 12.5d;
        //}

        public bool IsPaymentPossible(double money)
        {
            if (AmountOnCard < money || AmountOnCard <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public double AddMoney(double money)
        {
            AmountOnCard += money;
            return AmountOnCard;
        }

        public double MakePayment(double money)
        {
            //add exception
            if (AmountOnCard <= 0)
            {
                Console.WriteLine($"You don't have money on your account. Please top-up");
                return 0;
            }
            else
            {
                AmountOnCard -= money;
                return AmountOnCard;
            }
        }

        public override string ToString()
        {
            return AmountOnCard.ToString();
        }
    }
}
