using System;

namespace Homework3Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please add number 1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please add number 2");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please add number 3");
            int num3 = int.Parse(Console.ReadLine());
            if (num1 > 100 && num2 > 100)
            {
                Console.WriteLine($"{num1} and {num2} are more than 100");
            }
            //Если только одно из чисел А и В четное  - вывести сообщение "Только одно из чисел А и В четное"
            if ((num1 % 2 == 0 && num2 % 2 != 0) || (num2 % 2 == 0 && num1 % 2 != 0))
            {
                Console.WriteLine($"Only one of the numbers {num1}, {num2} is even");
            }
            if (num1 > 0 || num2 > 0)
            {
                Console.WriteLine($"One of the numbers {num1}, {num2} is positive");
            }
            if (num3 % 3 == 0 && num2 % 3 == 0 && num3 % 3 == 0)
            {
                Console.WriteLine($"Each of the numbers {num1}, {num2}, {num3} is divided into 3");
            }
            //Если только одно из чисел А, В и С меньше 50 - вывести сообщение "Только одно из чисел А, В и С меньше 50":
            if ((num1 < 50 && num2 >= 50 && num3 >= 50) || (num2 < 50 && num1 >=50 && num3 >= 50) || (num3 < 50 && num1 >= 50 && num2 >=50))
            {
                Console.WriteLine($"Only one of the numbers {num1}, {num2}, {num3} is less than 50");
            }
            if (num1 < 0 || num2 < 0 || num3 < 0)
            {
                Console.WriteLine($"One of the numbers {num1} or {num2} or {num3} is negative");
            }
            Console.ReadKey();
        }
    }
}
