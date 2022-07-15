using System;
// TASK 2: first way to output sequence of numbers
namespace Homework1b
{

    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please insert n1");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert n2");
            int n2 = int.Parse(Console.ReadLine());

            if (n1 < n2)
            {
                while (n1 <= n2)
                {
                    int n = n2 - n1 + 1;
                    Console.WriteLine(n1++);
                }
            }
            else
            {
                while (n2 <= n1)
                {
                    int n = n1 - n2 + 1;
                    Console.WriteLine(n2++);
                }
            }
            Console.ReadKey();
        }
    }
}
