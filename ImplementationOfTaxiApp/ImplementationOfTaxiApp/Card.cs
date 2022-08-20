﻿using System;
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

        public string CardNumber
        {
            get
            {
                return _cardnumber;
            }
            set
            {
                //if (value == "")
                //{
                    //Console.WriteLine("Please set your cardnumber");
                    //_cardnumber = Console.ReadLine();
                    _cardnumber = value;

                //}
                //else
                //{
                //    _cardnumber = value;
                //}
            }
        }
        public double AmountOnCard
        {
            get => _amountOnCard;
            set
            {
                _amountOnCard = value;
            }
        }

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
