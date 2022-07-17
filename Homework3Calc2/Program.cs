using System;
//second calculator (with if-else)
namespace Lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type number1");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Type number2");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Type operation ('+' or '-'or '*' or '%' or '/' or 'AC'");
            string sign = Console.ReadLine();
            if (sign == "-")
            {
                Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
            }
            else if (sign == "+")
            {
                Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
            }
            else if (sign == "*")
            {
                Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
            }
            else if (sign == "/")
            {
                if (number2 != 0)
                {
                    Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
                }
                else
                {
                    Console.WriteLine("Impossible to count. Please write a correct number2");
                    number2 = int.Parse(Console.ReadLine());
                    if (number2 != 0)
                    {
                        Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                }
            }
            else if (sign == "%")
            {
                Console.WriteLine($"{number1} % {number2} = {number1 % number2}");
            }
            else if (sign == "AC")
            {
                Console.Clear();
                Console.WriteLine("Please start from the scratch");
            }
            else
            {
                Console.WriteLine("You typed the wrong symbol!");
            }
            Console.ReadKey();
        }
    }
}
