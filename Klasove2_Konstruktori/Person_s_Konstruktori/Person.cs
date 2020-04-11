using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_s_Konstruktori
{
    class Person
    {
        private string name;
        private int age;
        private List<BankAccaunts> akaunt;

        public Person(string name, int age)
      : this(name, age, new List<BankAccaunts>())
    {}


        //Пълен конструктор
        public Person(string name, int age, List<BankAccaunts> akaunt)
        {
            this.name = name;
            this.age = age;
            this.akaunt = akaunt;
        }

                      

        public double GetBalance()
        {
            return akaunt.Sum(x=>x.Amount);
        }
    }
}
