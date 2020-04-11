using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankovaSmetka
{
    class BankAccount
    {
        private string numberID;
        private int balance;

        public string NumberID
        {
            get { return numberID; }
            set { numberID = value; }
        }

        public int Balance
        {
            get { return balance; }
            set { balance = value;}
        }

        public void Deposit(int kolichestvo)
        {
            balance += kolichestvo;
        }

        public void Withdraw(int  amount)
        {
            balance -= amount;
        }

    }
}
