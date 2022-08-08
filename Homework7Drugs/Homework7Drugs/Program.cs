using System;

namespace Homework7Drugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Medicine:");
            Medicine medicine = new Ointment("Ointment", 0, "fds");
            medicine.WayOfApplication();
            Ointment o1 = (Ointment)medicine;
            Medicine medicine1 = new Ointment("Ointment", 8, "without smell");
                                    //Console.WriteLine($"1. Ointment:");
                                    //medicine1.Print();
                                    //medicine1.WayOfApplication();
            Medicine medicine2 = new Pill("Pill", 5, "bitter");
                                    //Console.WriteLine("2. Pill");
                                    //medicine2.Print();
                                    //medicine2.WayOfApplication();
            Pill medicine3 = new Syrup("Syrup", 12, "sweet", 16);
                                    //Console.WriteLine("3. Syrup");
                                    //medicine3.Print();
                                    //medicine3.WayOfApplication();
            Medicine[] typeOfMedicine = new Medicine[]
            {
                medicine1,
                medicine2,
                medicine3,
            };
            foreach (Medicine elements in typeOfMedicine)
            {
                elements.Print();
                elements.WayOfApplication();
            }

        }
    }
}
