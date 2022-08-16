using System;
using System.Collections.Generic;

namespace ImplementationOfTaxiApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Card card = new Card();
            //Cash cash = new Cash(26.3d);
            //Points points = new Points(0);

            //Dictionary<string, IPaymentMethod> paymentMethods = new Dictionary<string, IPaymentMethod>
            //{
            //    {"Cash", new Cash},
            //    {"Card", Card},
            //    {"Points", Points}
            //};
            List<ITaxi> taxiTypes = new List<ITaxi>()
            {
                new Car("664AC",549.3d,"MAZDA", "black", 259.5d),
                new Helicopter("665TU", 5003.8d, "VERTAL", 208d, 1390.4d),
                new Motorbike("666CI", 560d, 304.7d, 7.0d, "YAMAHA"),
            };
            //как добавить параметры, если последним параметром является Dictionary?
            
            User user = new User("Hanna", "Ivanova", "+375293833758");
            
            //menu:
            int menu = 0;
            while (menu != 4)
            {
                Console.WriteLine("\t1. Add a card." + Environment.NewLine +
                "\t2.Top up card." + Environment.NewLine +
                "\t3.Process the trip" + Environment.NewLine +
                "\t4. Nothing. Exit the app.");

                Console.WriteLine("Please select the item.");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        {
                            Console.WriteLine($"Please create a card name");
                            string cardName = Console.ReadLine();
                            Console.WriteLine("PLease indicate number of the card (requisites)");
                            string cardNumber = Console.ReadLine();
                            Console.WriteLine("Please type value of sum you want to top up the card");
                            double sumOfMoney = double.Parse(Console.ReadLine());
                            user.AddCard(cardName, new Card(sumOfMoney) { CardNumber = cardNumber});
                            Console.WriteLine($"{sumOfMoney} has been added on {cardName}, {cardNumber}.");
                            //user.ToUpCard(cardName, sumOfMoney);
                            
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("Please insert number of card you want to top up");
                            string cardName = Console.ReadLine();
                            Console.WriteLine("Please type value of sum you want to top up the card");
                            double sumOfMoney = double.Parse(Console.ReadLine());
                            user.ToUpCard(cardName, sumOfMoney);
                            user.ToString();
                            break;
                        }

                    case 3:
                        {
                            int counter = 1;
                            foreach (ITaxi taxitype in taxiTypes)
                            {
                                //Console.WriteLine($"Available taxi types: {taxitype}\n");
                                Console.WriteLine($"{counter}. Available taxi types + {taxitype.ToString()}\n");
                                counter++;
                            }
                            Console.WriteLine("Please choose the number of the desired type of transport");
                            int typeOfTransport = int.Parse(Console.ReadLine());
                            double priceOfRide = taxiTypes[typeOfTransport-1].GetPriceOfRide();
                            Console.WriteLine("Insert the way of payment");
                            user.ToString();
                            string paymentmethod = Console.ReadLine();

                            if (user.PaymentMethods[paymentmethod].IsPaymentPossible(priceOfRide))
                            {
                                user.PaymentMethods[paymentmethod].MakePayment(priceOfRide);
                                taxiTypes[typeOfTransport-1].MakeRide(user);
                            }

                            else
                            {
                                Console.WriteLine("Lack of money!");
                            }

                            break;
                        }
                        
                    case 4:
                        {
                            Console.WriteLine("You will be get out from the app.");
                            break;
                            
                        }
                    default:
                        {
                            Console.WriteLine("Please type a valid option");
                            break;
                        }
                }
            }
        }
    }
}
