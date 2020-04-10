using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BankAccount
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
            set { balance = value;}
        }

        public  void Deposit (double amount)
        {
            balance += amount;
        }
        public void Withdraw(double amount)
        {
            balance -= amount;
        }
    }
}
