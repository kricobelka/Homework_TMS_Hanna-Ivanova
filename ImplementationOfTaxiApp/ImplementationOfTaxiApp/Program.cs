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

            Dictionary<string, IPaymentMethod> paymentMethods = new Dictionary<string, IPaymentMethod>
            {
                {"Cash", Cash},
                {"Card", Card},
                {"Points", Points}
            };
            List<ITaxi> taxiTypes = new List<ITaxi>()
            {
                new Car("664AC",549.3d,"MAZDA", "black", 259.5d),
                new Helicopter("665TU", 5003.8d, "VERTAL", 208d, 1390.4d),
                new Motorbike("666CI", 560d, 304.7d, 7.0d, "YAMAHA"),
            };
            //как добавить параметры, если последним параметром является Dictionary?
            
            User user = new User("Hanna", "Ivanova", "+375293833758", Dictionary<"Card", Card);

            //menu:
            int menu = 0;
            while (menu != 4)
            {
                Console.WriteLine("\t1. Add a card." + Environment.NewLine +
                "\t2.Top up card." + Environment.NewLine +
                "\t3.Process the trip" + Environment.NewLine +
                "\t4. Nothing. Exit from the app.");

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
                            user.AddCard(cardName, new Card() { CardNumber = cardNumber });
                            //user.ToUpCard(cardName, sumOfMoney);
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("Please insert number of card you want to top up");
                            string cardNumber = Console.ReadLine();
                            Console.WriteLine("Please type value of sum you want to top up the card");
                            double sumOfMoney = double.Parse(Console.ReadLine());
                            user.ToUpCard(cardNumber, sumOfMoney);
                            break;
                        }

                    case 3:
                        {
                            foreach (ITaxi taxitype in taxiTypes)
                            {
                                //Console.WriteLine($"Available taxi types: {taxitype}\n");
                                Console.WriteLine($"Available taxi types + {taxitype.ToString()}\n");

                            }
                            
                        }
                }
            }
        }
    }
}
