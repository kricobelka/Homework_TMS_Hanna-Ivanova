using System;

namespace Homework11Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Employee employee = new Employee();
                employee.Name = @"hek";
                //employee.Name = @"Ahelesgingfjnksjndksnlksnflksdmlksmskl
                //                nfldksnflskdmfldskmfldksmffdsfdsfdsf
                //                    dsfdsfdsfdsfdksnfkldfdsssssfdsfd
                //                        kfdsffdsfrfrlljjkhtrkkl";
                //employee.Age = 16;
                employee.Salary = -7;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

        }
    }
}
