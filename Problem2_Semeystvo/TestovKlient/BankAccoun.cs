using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestovKlient
{
    class BankAccoun
    {
        //Номер на банкова сметка
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        //Баланс на сметката
        private double balance;
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        //Внасяне на пари
        public void Deposit(double amount)
        {
            balance += amount;
        }

        //Теглена на пари
        public void Withdraw(double amount)
        {
            if (balance<amount)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                balance -= amount;
            }

            
        }

        //Печат на сметка
        public void Print()
        {
            Console.WriteLine($"Account ID {id}, balance { balance:f2}");
        }



    }
}
