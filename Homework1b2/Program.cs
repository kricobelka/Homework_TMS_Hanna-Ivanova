using System;
// TASK 2: second way to output sequence of numbers
namespace Homework1b2
{
    class Program
    {
        public static void Main()
        {
            //List<int> numbers = new List<int>();
            Console.WriteLine("Insert number a");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Insert number b");
            int b = Int32.Parse(Console.ReadLine());
            if (a >= b)
            {
                // { Console.WriteLine("{0} не должно быть больше или равно {1}", a, b);
                //Console.ReadKey(); }

                for (int i = a - b; b <= a; b++)
                {
                    Console.WriteLine(b);
                }

            }
            else if (b >= a)
            {
                for (int i = b - a; b >= a; a++)
                {
                    Console.WriteLine(a);
                }
            }
            //foreach (var value in numbers)
            //{
            //  Console.Write("{0} ", value);
            //}
            //Console.WriteLine("Количество элементов равно {0}", numbers.Count);
            Console.ReadKey();
            //numbers.Add(i);
        }
    }
}

