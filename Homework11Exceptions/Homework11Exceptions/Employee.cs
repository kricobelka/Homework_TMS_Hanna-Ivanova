using System;
using System.Collections.Generic;
using System.Text;

namespace Homework11Exceptions
{
    internal class Employee
    {
        private int _age;
        private string _name;
        private double _salary;
        public int Age
        {
            get => _age;

            set
            {
                if (value > 0 && value >= 18)
                {
                    _age = value;
                }
                else
                {
                    throw new Exception($"Error. The age {value} is less than 18");
                }
            }
        }

        public string Name
        {
            get => _name;

            set
            {
                if ((value != null || value != "") && value.Length <= 100)
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException($"Error. The {value} is more than 100 symbols");
                    //throw new ArgumentNullException($"The value {value} is null or empry");
                    throw new ArgumentNullException(value);
                }
            }
        }

        public double Salary
        {
            get => _salary;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Error. The {value} is less than 0 or equal to 0");
                }

                else
                {
                    _salary = value;
                }
            }
        }
        //если я напишу argumentnullexception и argumentexception, будет отлавливать обе ошибки по порядку?
        // если написала просто Exception, отловит также все ошибки? АНалогично первому вводу?
    }
}
    
