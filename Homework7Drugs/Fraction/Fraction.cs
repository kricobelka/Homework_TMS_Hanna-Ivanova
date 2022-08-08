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
            get; set;
        }

        public int Denumerator
        {
            //переносить ли на след строку return и в каких случаях?
            get { return (int)_denumerator; }
            set
            {
                if (value < 0)
                {
                    _denumerator = Math.Abs(value);
 
                }
                else
                {
                    _denumerator = value;
                }
            }
        }
        internal static void Print (Fraction fraction)
        {
            Console.WriteLine($"The fraction result is { fraction.Numerator / fraction.Denumerator}");
        }

        public static Fraction Addition(Fraction fraction1, Fraction fraction2)
        {
            int num = 0;
            int denum = 0;
            int nod = 0;
            var result = new Fraction(num,denum);
            result.Denumerator = fraction1.Denumerator * fraction2.Denumerator;
            result.Numerator = (fraction1.Numerator * (result.Denumerator / fraction1.Denumerator)) + (fraction2.Numerator * (result.Denumerator / fraction2.Denumerator));
            // полуичли результат дроби после сложения и привдеение знаменателей
            //находим нод результата дроби:
            for (int i = 1; i < (result.Denumerator / result.Numerator + 1); i++)
            {
                if (result.Numerator % i == 0 && result.Denumerator % i == 0)
                {
                    nod = i;
                    num = result.Numerator;
                    denum = result.Denumerator;
                }
            }
            //is it necessary to relate num and denum to result umerator and denumerator?
            //no
            //num = result.Numerator;
            //denum = result.Denumerator;
            //num = result.Numerator  / nod;
            //denum = result.Denumerator / nod;
            num /= nod;
            denum /= nod;
            //resultfraction = num / denum;
            //Console.WriteLine(resultfraction);
            return result;
        }

        // почему все время корректно возвращает, даже если название переменной fraction не совпадает?
        public int Subtraction(Fraction fraction)
        {
                return Numerator - Denumerator;
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

