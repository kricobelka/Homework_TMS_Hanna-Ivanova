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
            if (num1 % 2 == 0 || num2 % 2 == 0)
            {
                Console.WriteLine($"{num1} or {num2} is odd");
            }
            if (num1 > 0 || num2 > 0) //Если только одно из чисел А и В четное  - вывести сообщение "Только одно из чисел А и В четное"
            {
                Console.WriteLine($"One of the numbers {num1} {num2} is positive");
            }
            if (num3 % 3 == 0 && num2 % 3 == 0 && num3 % 3 == 0)
            {
                Console.WriteLine($"Each of the numbers {num1} {num2} {num3} is divided into 3");
            }
//            Если только одно из чисел А, В и С меньше 50 - вывести сообщение "Только одно из чисел А, В и С меньше 50"
//Если хотя бы одно из чисел А, В, С отрицательное -вывести сообщение "Одно из чисел А, В, С отрицательное"

            }
        }
    }
