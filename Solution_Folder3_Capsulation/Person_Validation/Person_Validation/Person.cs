using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Validation
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private double salary;
        private List<Person> hora = new List<Person>();

        public Person()
        { }

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Person(string firstName,string lastName,int age):this(firstName,lastName)
        {
            this.Age = age;
        }

        public Person(string firstName, string lastName, int age, double salary):this(firstName,lastName,age)
        {
           this.Salary = salary;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
                {
                if (value.Length<=3)
                {
                    throw new ArgumentException("Fisrt name should be more than 3 symbols");
                }
                this.firstName = value;
                }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value.Length <= 3)
                {
                    throw new ArgumentException("Last name should be more than 3 symbols");
                }
                this.lastName = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value<1)
                {
                    throw new ArgumentException("Age should be more than 0");
                }
                this.age = value;
            }
        }

        public double Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 460)
                {
                    throw new ArgumentException("Salary should be more than 460");
                }
                this.salary = value;
            }
        }
       // public List<Person> Hora
       // {
       //     get { return hora; }
       //     set { hora = value;}
       // }

        public void IncreaseSalary(double percent)
        {
            if (age>30)
            {
                salary +=this.salary * percent/100;
            }
            else
            {
                salary += this.salary * percent / 200;
            }
        }

        public override string ToString()
        {
            return $"Name:{FirstName} {LastName},{Age} years old,Salary: {Salary}";
        }
    }
}
