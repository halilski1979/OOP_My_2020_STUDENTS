using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Person_s_Konstruktori
{
    public class BankAccaunts
    {
        private string id;
        private int amount;

        public string ID
        {
            get => id;
            set => id = value;
        }

        public int Amount
        {
            get => amount;
            set => amount = value;
        }

        public BankAccaunts()
        {
        }

        public BankAccaunts(string id, int amount)
        {
            this.id = id;
            this.amount = amount;
        }

    }
}