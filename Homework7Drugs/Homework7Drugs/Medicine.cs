using System;
using System.Collections.Generic;
using System.Text;

namespace Homework7Drugs
{
    internal abstract class Medicine
    {
        // удаляем поля где установили автосвойство (name)
        //private string _name;
        private int _cost;
        public Medicine(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }
        public string Name
        {
            get;
            set;
        }

        public int Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                if (value < 0)
                {
                    _cost = 0;
                    Console.WriteLine("Cost cannot be less than '0");
                }
                else
                {
                    _cost = value;
                }
            }
        }
        public virtual void Print()
        {
            //почему выводит только первое значение?
            //Console.WriteLine(Name, Cost);
            Console.WriteLine($"Name of medicine is {Name}, cost of medicine is {Cost} dollars.");
        }
        public abstract void WayOfApplication();
        
    }
}
