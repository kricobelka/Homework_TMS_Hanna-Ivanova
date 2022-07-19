using System;
//first calculator (with switch-case)
namespace Homework3calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type the first number");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please type the second number");
            int number2 = int.Parse(Console.ReadLine());
            //int i = 0;
            // while (i != -1)
            Console.WriteLine("Choose an operation to receive a result:" + Environment.NewLine +
                "\tp - Plus" + Environment.NewLine +
                "\td - Divide" + Environment.NewLine +
                "\tm - Multiply" + Environment.NewLine +
                "\tmin - Minus" + Environment.NewLine +
                //"\tc - Clear (AC)" + Environment.NewLine +
                "\tr - Remainder (%)");
            //string operation = Console.ReadLine();
           // switch (operation)
           switch (Console.ReadLine())
            {
                case "a":
                    {
                        Console.WriteLine($"The result is {number1} + {number2} = {number1 + number2}");
                        break;
                    }
                case "d":
                    {
                        if (number2 != 0)
                        {
                            Console.WriteLine($"The result is {number1} / {number2} = {number1 / number2}");
                        }
                        else
                        {
                            Console.WriteLine("Error. Please insert corretc second number.");
                        }
                        number2 = int.Parse(Console.ReadLine());
                        if (number2 != 0)
                        {
                            Console.WriteLine($"The result is {number1} / {number2} = {number1 / number2}");
                        }
                        else
                        {
                            Console.WriteLine("Error. Please insert corretc second number.");
                            Console.ReadLine();
                        }
                        break;
                    }
                case "m":
                    {
                        Console.WriteLine($"The result is {number1} * {number2} = {number1 * number2}");
                        break;
                    }
                case "min":
                    {
                        Console.WriteLine($"The result is {number1} - {number2} = {number1 - number2}");
                        break;
                    }
                case "r":
                    {
                        Console.WriteLine($"The result is {number1} % {number2} = {number1 % number2}");
                        break;
                    }
                //case "c":
                //    Console.WriteLine("");
                //    Console.WriteLine("Please insert new numbers");
                //    number1 = int.Parse(Console.ReadLine());
                //    number2 = int.Parse(Console.ReadLine());
                default:
                    {
                        Console.WriteLine("Wrong option!");
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
// culculator app through if-else is indicated in homwork3calc2
