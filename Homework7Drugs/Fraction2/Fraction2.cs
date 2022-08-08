using System;
using System.Collections.Generic;
using System.Text;

namespace Fraction
{
    internal class Fraction
    {
        //private double _numerator;
        private int _denumerator;

        public Fraction(int numerator, int denumerator)
        {
            //var nod = Fraction.Nod(numerator, denumerator);
            //Numerator = numerator / nod;
            //Denumerator = denumerator / nod;
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
            get { return _denumerator; }
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

        public static Fraction Addition(Fraction fraction1, Fraction fraction2)
        {
            var nod = 0;
            var result = new Fraction(fraction1.Numerator * fraction2.Denumerator + fraction2.Numerator * fraction1.Denumerator, fraction1.Denumerator * fraction2.Denumerator);
            // полуичли результат дроби после сложения и привдеение знаменателей
            // находим нод:
            if (result.Denumerator > result.Numerator)
            {
                for (int i = 1; i < (result.Denumerator / result.Numerator + 1); i++)
                {
                    if (fraction1.Numerator % i == 0 && fraction1.Denumerator % i == 0)
                    {
                        nod = i;
                    }
                }
            }
            else
            {
                for (int i = 1; i < (result.Numerator / result.Denumerator + 1); i++)
                {
                    if (fraction1.Numerator % i == 0 && fraction1.Denumerator % i == 0)
                    {
                        nod = i;
                    }
                }
            }
            result.Denumerator /= nod;
            result.Numerator /= nod;
            return result;
        }
        // способ нахождения нода путем создания отдельного метода:
        //public static int Nod(int numerator, int denumerator)
        //{
        //    numerator = Math.Abs(numerator);
        //    denumerator = Math.Abs(denumerator);
        //    while (denumerator != 0 && numerator != 0)
        //    {
        //        if (numerator % denumerator > 0)
        //        {
        //            var temp = numerator;
        //            numerator = denumerator;
        //            denumerator = temp % denumerator;
        //        }
        //        else
        //        {
        //            break;
        //        }
        //    }
        //    if (denumerator != 0 && numerator != 0)
        //    {
        //        return denumerator;
        //    }
        //    return 1;
        //}

        public static Fraction Subtraction(Fraction fraction1, Fraction fraction2)
        {
            var result = new Fraction(fraction1.Numerator * fraction2.Denumerator - fraction2.Numerator * fraction1.Denumerator, fraction1.Denumerator * fraction2.Denumerator);
            var nod = 0;
            if (result.Denumerator > result.Numerator)
            {
                for (int i = 1; i < (result.Denumerator / result.Numerator + 1); i++)
                {
                    if (fraction1.Numerator % i == 0 && fraction1.Denumerator % i == 0)
                    {
                        nod = i;
                    }
                }
            }
            else
            {
                for (int i = 1; i < (result.Numerator / result.Denumerator + 1); i++)
                {
                    if (fraction1.Numerator % i == 0 && fraction1.Denumerator % i == 0)
                    {
                        nod = i;
                    }
                }
            }
            result.Denumerator /= nod;
            result.Numerator /= nod;
            return result;
        }

        public static Fraction Multiplication(Fraction fraction1, Fraction fraction2)
        {
            var result = new Fraction(fraction1.Numerator * fraction2.Numerator, fraction1.Denumerator * fraction2.Denumerator);
            return result;
        }

        public static Fraction Division(Fraction fraction1, Fraction fraction2)
        {
            var result = new Fraction(fraction1.Numerator * fraction2.Denumerator, fraction1.Denumerator * fraction2.Numerator);
            return result;
        }

        //kak output through variable?
        //public int Multiplication(Fraction fraction1, Fraction fraction2)
        //{
        //    return fraction1.Numerator * fraction2.Denumerator / fraction1.Denumerator * fraction2.Denumerator;
        //}

        public static void Print(Fraction fraction)
        {
            Console.WriteLine($"The fraction result is {fraction.Numerator}/ {fraction.Denumerator}");
        }

        public static double ToDecimal(Fraction fraction)
        {
            return (double)fraction.Numerator / fraction.Denumerator;
        }
    }
}

