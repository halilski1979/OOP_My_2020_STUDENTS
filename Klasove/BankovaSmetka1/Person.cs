using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankovaSmetka1
{
    class Person
    {
        private string name;
        private int age;
        private List<BankAccaount> akaunt = new List<BankAccaount>();

        public string Name
        {
            get { return name; }
            set { name = value;}
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public List<BankAccaount> Akaunt
        {
            get { return akaunt; }
            set { akaunt = value;}
        }

        public double GetBalance()
        {
            return Akaunt.Sum(x=>x.Balance);
        }

    }
}
