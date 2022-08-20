using System;

namespace Homework10Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //static void WarmUpCompletedHandler(string dishWarmedUp)
                Microwave microwave1 = new Microwave();
                //Console.WriteLine($"You dish {dishWarmedUp} has been warmed up");
                microwave1.WarmUpCompleted += WarmUpCompletedHandler;
                microwave1.WarmUp($"You dish  has been warmed up");
 
        }
        private static void WarmUpCompletedHandler(string dishWarmedUp) => Console.WriteLine(dishWarmedUp);
    }
}
