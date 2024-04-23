using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29___23._04
{
    internal class Employee:Person
    {
        public Double Salary { get; set; }

        public Employee(string name, string surname, int age, double salary) : base(name, surname, age)
        {
            Salary=salary;
        }
    }
}
