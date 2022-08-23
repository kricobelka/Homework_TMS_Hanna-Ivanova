using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeesHomework
{
    internal class Employee
    {
        private int _age;

        public Employee(string name, int age, int experience, bool higherEducation)
        {
            Name = name;
            Age = age;
            Experience = experience;
            HigherEducation = higherEducation;
        }
        public string Name { get; set; }
        public int Age
        {
            get => _age;
            set
            {
                if (value <= 0)
                {
                    _age = 16;
                    Console.WriteLine("Error!");
                }
                else
                {
                    _age = value;
                }
            }
        }

        public int Experience { get; set; }
        public bool HigherEducation { get; set; }

        public static void CountSalary(List<Employee> employeeList)
        {
            double salary = 0;
            foreach (Employee employee in employeeList)
            {
                if (employee.HigherEducation)
                {
                    salary = (employee.Experience + 1) * 1250;
                    Console.WriteLine($"{employee.Name} salary is {salary}");
                }
                else if (!employee.HigherEducation)
                {
                    salary = (employee.Experience + 1) * 1000;
                    Console.WriteLine($"{employee.Name} salary is {salary}");
                }
            }
        }

        public static void CountSalaryWithDelegate(List<Employee> employeeList, DelegateCountSalary salaryWithDelegate)
        {
            foreach (var employee in employeeList)
            {
                //не понятна след строчка:
                int salary = salaryWithDelegate(employee);
                Console.WriteLine($"{employee.Name} salary is {salary}");

            }
        }

        public delegate int DelegateCountSalary(Employee employee);
        //public delegate int DelegateForLambda(Employee employee);
    }
}