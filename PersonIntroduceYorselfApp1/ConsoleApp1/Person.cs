using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        private string name;
        private int age;
        private List<BankAccount> akaunt = new List<BankAccount>();

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value;}
        }

        public List<BankAccount> Akaunt
        {
            get { return akaunt; }
            set { akaunt = value; }
        }
        
        public double GetBalance()
        {
           return Akaunt.Sum(x=>x.Balance);
        }
    }
}
