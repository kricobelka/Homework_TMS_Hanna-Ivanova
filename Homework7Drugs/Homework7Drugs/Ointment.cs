using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7Drugs
{
    internal class Ointment : Medicine
    {
        public Ointment(string name, int cost, string smell) : base(name,cost)
        {
           Smell = smell;
        }
        public string Smell { get; set; }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Smell of {Name} is {Smell}.");
            // как вывести вместе в одну строкуbase print(старые свойства) и новые свойства ?
        }
        public override void WayOfApplication()
        {
            Console.WriteLine($"{Name} is for external use.");
        }
    }
}


