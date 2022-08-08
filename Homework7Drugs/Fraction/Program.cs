using System;

namespace Fraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            Fraction fraction1 = new Fraction(12, 50);
            Fraction fraction2 = new Fraction(5, 25);
            Fraction.Print(Fraction.Addition(fraction1, fraction2));
            Console.WriteLine(Fraction.Addition(fraction1, fraction2));


            //Console.WriteLine(fraction1.Subtraction(fraction1));
            ////ffraction1.Division(fraction1);
            ////double fraction3 = (double)fraction1.Division(fraction1);
            //Console.WriteLine(fraction1.Division(fraction1));
            //Console.WriteLine(fraction1.Multiplication(fraction1));

        }
    }
}
