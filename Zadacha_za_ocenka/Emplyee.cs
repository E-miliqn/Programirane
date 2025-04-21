using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_za_ocenka
{
    internal class Employee
    {
        public string Name;
        public double Salary;
        public string Position;
        public string Department;
        public string Email;
        public int Age;

        public Employee(string name, double salary, string position, string department, string email = "n/a", int age = -1)
        {
            Name = name;
            Salary = salary;
            Position = position;
            Department = department;
            Email = email;
            Age = age;
        }
    }
}
