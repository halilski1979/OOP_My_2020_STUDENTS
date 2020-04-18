using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_this_Capsulation
{
    public class Person
    {
        private string firstName;
        private string secondName;
        private int age;

        public Person(string firstName, string secondName, int age)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.age = age;
           
            
            //FirstName = firstName;
            //SecondName = secondName;
            //Age = age;
        }

        public string FirstName
        {
            get { return this.firstName; }
            //set { firstName = value; }
        }

        public string SecondName
        {
            get { return this.secondName; }
            //set { secondName = value; }
        }
       
        public int Age
        {
            get { return age; }
            //set { age = value; }
        }

        public override string ToString()
        {
            return $"{FirstName} {SecondName} is a {Age} years old";
        }
    }
}
