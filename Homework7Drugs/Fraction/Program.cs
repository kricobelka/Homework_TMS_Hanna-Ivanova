using System;

namespace Fraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction(15,25);
            Fraction fraction2 = new Fraction(6, 42);
            Console.WriteLine(fraction1.Addition(fraction1));
            Console.WriteLine(fraction1.Subtraction(fraction1));
            //ffraction1.Division(fraction1);
            //double fraction3 = (double)fraction1.Division(fraction1);
            Console.WriteLine(fraction1.Division(fraction1));
            Console.WriteLine(fraction1.Multiplication(fraction1));

            //метод нельзя вызвать соед образом, тк
            //он принимает параметры? fraction1.Multiplication(fraction1);

        }
    }
}
