using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeee
{
    public class Employee
    {
        public Employee(string name, decimal salary, string position, string department)
        {
            Name = name;
            Salary = salary;
            Position = position;
            Department = department;
            this.Age = -1;
            this.Email = "n/a";
        }

        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} {Salary:F2} {Email} {Age}";
        }
    }
}
