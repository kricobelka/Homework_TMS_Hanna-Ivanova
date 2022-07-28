using System;

namespace HomeworkIphoneclass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Iphone iphone = new Iphone("38337", "Iphone 12", 250d);
            Console.WriteLine(iphone);
            Console.WriteLine($"number: {iphone.Number}, model: {iphone.Model}, weight: {iphone.Weight}");
            iphone.Weight = -7;
            Console.WriteLine(iphone.Weight);
            iphone.ReceiveCall("nameofcaller");

        }
    }
}
