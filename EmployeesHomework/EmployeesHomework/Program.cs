﻿using System;
using System.Collections.Generic;

namespace EmployeesHomework
{
    internal class Program
    {
        //public delegate int DelegateCountSalary(Employee employee);

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

            Console.WriteLine("Count without delegate:\n");
            Employee.CountSalary(employeelist);

            Console.WriteLine("\nCount with delegate:\n");
            Employee.CountSalaryWithDelegate(employeelist, CountSalaryWithDelegate1);


            static int CountSalaryWithDelegate1(Employee employee)
            {
                int salary = 0;
                if (employee.HigherEducation)
                {
                    salary = (employee.Experience + 1) * 1000;
                }
                else if (!employee.HigherEducation)
                {
                    salary = (employee.Experience + 1) * 700;
                }
                return salary;
            }
  
            //Employee.CountSalaryWithDelegate(employeelist, salaryWithDelegate);
            
        }
    }
}
