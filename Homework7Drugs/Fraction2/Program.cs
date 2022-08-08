using System;

namespace Fraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction(12, 50);
            Fraction fraction2 = new Fraction(5, 25);
            Fraction.Print(Fraction.Addition(fraction1, fraction2));
            Fraction.Print(Fraction.Subtraction(fraction1, fraction2));
            // как приравнять к decimal результат дроби?
            Fraction.ToDecimal(Fraction.Addition(fraction1, fraction2));
            Fraction.ToDecimal(Fraction.Subtraction(fraction1, fraction2));
            //Console.WriteLine($"The fractions in double is {Fraction.ToDecimal (fraction1)} and {Fraction.ToDecimal(fraction2)}.");

            Fraction.Print(Fraction.Multiplication(fraction1, fraction2));
            // kak вывести multiplication через переменную, если есть классы?
            // привести класс к дабл?

            Fraction.Print (Fraction.Division (fraction1, fraction2));
            
        }
    }
}