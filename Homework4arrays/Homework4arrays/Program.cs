using System;
using System.Linq;

namespace Homework4arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please insert the number of elements");
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("PLease insert elements of the array");
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine($"sum of the odd elements: {sum}");
            ////min e
            // first way to find minimum value from the array:
            var min = array.Min();
            Console.WriteLine(min);

            //second way to find minimum value from the array:
            int min2 = array[0];
                for (int i = 0; i < N; i++)
                {
                    if (array[0] < min)
                    {
                        min2 = array[0];
                    }
                }
                Console.WriteLine(min2);
            Console.ReadKey();
        }  
        }
        }

