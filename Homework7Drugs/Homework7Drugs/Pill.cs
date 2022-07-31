using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7Drugs
{
    internal class Pill : Medicine
    {
        public Pill(string name, int cost, string taste) : base (name, cost)
        {
            Taste = taste;
        }
        public string Taste 
        { 
            get; set; 
        }
        public override void Print ()
        {
            base.Print ();
            Console.WriteLine($"Taste of {Name} is {Taste}.");
        }
        public override void WayOfApplication()
        {
            //base.WayOfApplication();
            Console.WriteLine($"{Name} is for internal use. Please take 2 pills a day with food.");
        }
    }
}
