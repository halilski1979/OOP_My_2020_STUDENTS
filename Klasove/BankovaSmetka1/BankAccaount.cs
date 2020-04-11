using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankovaSmetka1
{
    class BankAccaount
    {
        private string numberID;
        private double balance;

        public string NumberID
        {
            get { return numberID; }
            set { numberID = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void Depozit(double amout)
        {
            balance += amout;
        }

        public void Teglene(double amount)
        {
            balance -= amount;
        }
    }
}
