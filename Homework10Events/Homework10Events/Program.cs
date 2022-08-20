using System;

namespace Homework10Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //static void WarmUpCompletedHandler(string dishWarmedUp)
                Microwave microwave1 = new Microwave();
            microwave1.WarmUpCompleted += WarmUpCompletedHandler;
            microwave1.WarmUp("Chicken");
            Console.WriteLine($"You dish is ready for lunch");
        }
        private static void WarmUpCompletedHandler(string dishWarmedUp) => Console.WriteLine(dishWarmedUp);
    }
}
