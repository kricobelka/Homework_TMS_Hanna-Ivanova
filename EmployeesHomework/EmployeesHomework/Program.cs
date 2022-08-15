using System;
using System.Collections.Generic;

namespace EmployeesHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeelist = new List<Employee>()
            {
                new Employee("Hek", 21, 1, true),
                new Employee ("Musya", 18, 0, false),
                new Employee ("Hector", 26, 5, true),
                new Employee ("Maria", 23, 3, true),
                new Employee ("Kevin", 31, 4, false)
            };
            Employee.CountSalary(employeelist);

            
        }
    }
}
