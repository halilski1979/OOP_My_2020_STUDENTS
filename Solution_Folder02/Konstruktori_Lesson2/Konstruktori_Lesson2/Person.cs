using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktori_Lesson2
{
    public class Person
    {
        private string name;
        private int age;
        private List<BankAccount> accounts=new List<BankAccount>() ;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public List<BankAccount> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }

        public Person(string name, int age, List<BankAccount> accounts)
        {
            this.name = name;
            this.age = age;
            this.accounts = accounts;
        }

        public Person()
        { }

        public Person(string name, int age) : this(name, age, new List<BankAccount>())
        { }

        public double GetBalnce()
        {
            return Accounts.Sum(x => x.Amount);
        }


        public void SortCountry()
        {
            Accounts = Accounts.OrderBy(x => x.Country).ToList();
        }



        public override string ToString()
        {
            return $"Name: {Name} is {Age} year old";
        }
    }
}
