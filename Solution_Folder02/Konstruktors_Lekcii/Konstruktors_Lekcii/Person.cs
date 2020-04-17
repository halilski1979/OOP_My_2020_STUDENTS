using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktors_Lekcii
{
    public class Person
    {
        private string name;
        private int age;
        private List<BankAccount> accounts = new List<BankAccount>();

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public List<BankAccount> Accounts { get => accounts; set => accounts = value; }

        public Person(string name, int age, List<BankAccount> accounts)
        {
            this.name = name;
            this.age = age;
            this.accounts = accounts;
        }

        public Person()
        {
        }

        public Person(string name, int age) : this(name, age, new List<BankAccount>())
        { }        
        

        public double Balance()
        {
            return this.accounts.Sum(x => x.Amount);
        }

        public override string ToString()
        {
            return $"Person: {Name} is {Age} old year.";
        }
    }
}
