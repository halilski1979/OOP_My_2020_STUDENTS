using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Word_BankAccount_MethodToString
{
    public class BankAccount
    {
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        private int balance;

        public int Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void Deposit(int amount)
        {
            balance += amount;
        }

        public void Withdraw(int amount)
        {
            balance -= amount;
        }

        public override string ToString()
        {
            return $"Nomer na smetka: {Id}={Balance}";
        }

        public void Print()
        {
            Console.WriteLine($"NumberID {Id}: {Balance} лева");
        }

        public string Print1()
        {
            return $"NumberID {Id}: {Balance} лева";
        }

    }
}
