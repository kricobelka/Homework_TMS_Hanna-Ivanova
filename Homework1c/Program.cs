using System;
//task 3
namespace Homework1c
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please insert quantity of pillars");
            int quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert distance between pillars");
            int distance = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert width of pillars");
            int width = int.Parse(Console.ReadLine());
            if (quantity == 1)
            {
                int finaldist = 0;
                Console.WriteLine(finaldist);
            }
            else
            {
                int finaldist = (quantity - 1) * width + (quantity - 1) * distance * 100 - width;
                Console.WriteLine(finaldist);
                Console.ReadKey();
            }
        }
    }
}
