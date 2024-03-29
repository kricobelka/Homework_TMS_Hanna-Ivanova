﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkIphoneclass
{
    public class Iphone
    {
        private double _weight;
        // все остальные параметры удалили, т.к установили автосвойство
        public Iphone(string number, string model, double weight)
        {
            Number = number;
            Model = model;
            Weight = weight;
        }

        public string Number { get; private set; }
        public string Model { get; set; }

        public double Weight
        {
            get { return _weight; }
            set
            {
                if (value < 0)
                {
                    _weight = 0;
                    Console.WriteLine("Wrong weight");
                }
                else
                {
                    _weight = value;
                }
            }
        }

        public void ReceiveCall(string nameofcaller)
        {
            Console.WriteLine("Name of caller is");
            //nameofcaller = Console.ReadLine();
            //Console.WriteLine($"{nameofcaller} is calling you");*/
        }
    }
}
