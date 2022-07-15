using System;

namespace Homework2fact
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the number you would like to factorial");
            int n = int.Parse(Console.ReadLine());
            int factorial = 1;
            
            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            Console.WriteLine(factorial);
                }
            Console.ReadKey();
            }
        }
    }
