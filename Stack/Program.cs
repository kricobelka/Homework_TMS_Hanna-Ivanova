using System;
using System.Collections.Generic;
namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3] { 3, 7, 18 };
            Stack<int> stack = new Stack<int>(array);
            foreach (int el in stack)
            {
                Console.WriteLine($"The stack includes the number" + " " + el);
            }
        }
    }
}
