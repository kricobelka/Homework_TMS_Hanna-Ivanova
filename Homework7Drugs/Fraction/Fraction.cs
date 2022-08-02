using System;
using System.Collections.Generic;
using System.Text;

namespace Fraction
{
    internal class Fraction
    {
        //private double _numerator;
        private double _denumerator;

        public Fraction(int numerator, int denumerator)
        {
            Numerator = numerator;
            Denumerator = denumerator;
        }

        public int Numerator
        {
            get; private set;
        }

        public int Denumerator
        {
            //переносить ли на след строку return и в каких случаях?
            get { return (int)_denumerator; }
            set
            {
                if (value < 0)
                {
                    _denumerator = 1;
                    Console.WriteLine("Denumerator must be positive");
                }
                else
                {
                    _denumerator = value;
                }
            }
        }
        public int Addition(Fraction fraction1)
        {
            return Numerator + Denumerator;
        }
        // почему все время корректно возвращает, даже если название переменной fraction не совпадает?
        public int Subtraction(Fraction fractio)
        {
            if (Numerator < Denumerator)
            {
                return Denumerator - Numerator;
            }
            else if (Numerator > Denumerator)
            {
                return Numerator - Denumerator;
            }
            else
            {
                return Numerator - Denumerator;
            }
        }
        public double Division(Fraction fraction1)
        {
            return (double)Numerator / Denumerator;
        }
        public int Multiplication(Fraction fraction1)
        {
            return Numerator * Denumerator;
        }
        //можно и след образом:
        //public int Multiplication ()
        //{
        //    return Numerator * Denumerator;
    }
}

