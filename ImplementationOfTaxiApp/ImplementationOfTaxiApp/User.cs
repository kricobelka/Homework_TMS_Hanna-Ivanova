using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementationOfTaxiApp
{
    internal class User
    {
        private string _username;
        private string _surname;
        private string _phone;
        private Dictionary<string, IPaymentMethod> _paymentMethods = new Dictionary<string, IPaymentMethod>();

        public User(string username, string surname, string phone)
            //в конструктор также надо добавить Dictionary, verno?
        {
            Username = username;
            Surname = surname;
            Phone = phone;
            //PaymentMethods = paymentMethods;
            PaymentMethods.Add("Card", new Card(18.5d));
            PaymentMethods.Add("Cash", new Cash(0));
            PaymentMethods.Add("Points", new Points(0));
            //в дикшинари свойство сначала стриг, потом метод платежа, почему мы должны писать вместо метода сумму денег?
        }

        public string Username { get; set; }

        public string Surname { get; set; }

        public string Phone 
        {
            get
            {
                return _phone;
            }
    set
            {
                _phone = value;
            }
        }

    public Dictionary<string, IPaymentMethod> PaymentMethods
        {
            get
            {
                return _paymentMethods;
            }
            set
            {
                _paymentMethods = value;
            }
        }

        public void ToUpCard(string cardName, double cardMoney)
        {
            //Console.WriteLine($"Please type card number  you want to top up");
            //cardName = Console.ReadLine();
            //Console.WriteLine($"Please type  amount of money you want to top up");
            //cardMoney = double.Parse(Console.ReadLine());
            if (PaymentMethods.ContainsKey(cardName))
            {
                PaymentMethods[cardName].AddMoney(cardMoney);
                Console.WriteLine($"Your current balance on {cardName} is {cardMoney}");
            }
            else
            {
                Console.WriteLine("You didn't add the card yet.");
                //PaymentMethods.Add(cardName, Card obj);
                // можно ил добавить карту в этом методе если ее не существут?
            }
        }

        public void ToUpCash(double cashMoney)
        {
            //Console.WriteLine($"Please insert the sum of cashMoney you would like to yop up:");
            //cashMoney = double.Parse(Console.ReadLine());
            PaymentMethods["Cash"].AddMoney(cashMoney);
            Console.WriteLine($"Your current balance of cash is {cashMoney}");
        }

        public void AddCard(string cardnumber, Card cardobj)
        {
            PaymentMethods.Add(cardnumber, cardobj);
            Console.WriteLine($"{cardobj} has been added");
        }

        //////как поймет что мы переопределяем у классов?
        //public override string ToString()
        //{
        //    var stringBuilder = new StringBuilder();
        //    return stringBuilder.ToString();
        //}

        //public void ShowAvailableMethods()
        //{
        //    foreach (var paymentmethod in PaymentMethods)
        //    {
        //        Console.WriteLine(paymentmethod);
        //    }
        //}
        ////или:
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var paymentmethod in PaymentMethods)
            {
                stringBuilder.Append ($"{paymentmethod.Key} --- {paymentmethod.Value}");
                stringBuilder.Append (Environment.NewLine);
            }
            return stringBuilder.ToString();
        }
    }
}
