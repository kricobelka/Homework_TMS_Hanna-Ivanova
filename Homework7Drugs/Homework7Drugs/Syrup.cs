using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7Drugs
{
    internal class Syrup : Pill
    {
        public Syrup(string name, int cost, string taste, int suitableAge) : base(name, cost, taste)
        {
            Name = name;
            Cost = cost;
            Taste = taste;
            SuitableAge = suitableAge;
        }
        public int SuitableAge 
        { 
            get; set; 
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"{Name} is  prescribed for adults and teenagers over 16 years.");
        }
        public override void WayOfApplication()
        {
            Console.WriteLine($"{Name} is for internal use. Please take {Name} twice a day after meal.");
        }
    }
}
