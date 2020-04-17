using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_w3_Zad3
{
    class Employee
    {
        // Име
        private string name;
        // Заплата
        private double salary;
        // Длъжност
        private string position;

        // Отдел
        private string department;

        // Електронна поща 
        private string email;
        // Възраст
        
        private int age;

        public Employee()
        {
            Email = "n/a";
            Age = -1;
        }
        public Employee(string name, double salary, string position, string department):this()
        {
            Name = name;
            Salary = salary;
            Position = position;
            Department = department;

        }
        public int AgeNew { get; set; }
        public string Name
        {
            get { return name; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name canot be null or empty!");
                }
                name = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public int Age
        {
            get { return age; }
            set { age = value;}
        }
    }
}
