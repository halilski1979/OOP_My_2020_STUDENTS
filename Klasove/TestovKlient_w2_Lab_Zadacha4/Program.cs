using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestovKlient_w2_Lab_Zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            var accounts = new Dictionary<int, BankAccount>();

            // Вход
            var linia = Console.ReadLine().Split().ToList();

            while (linia[0]!="End")
            {
                if (linia[0]=="Create")
                {
                    
                    if (accounts.ContainsKey(int.Parse(linia[1])))
                    {
                        Console.WriteLine("Account already exists");
                    }
                    else
                    {
                        int nomerSmetka = int.Parse(linia[1]);
                        //accounts[id] = new BankAccount() { Id = id };
                        accounts[nomerSmetka] = new BankAccount();
                    }
                }

                //Депозит 
                if (linia[0] == "Deposit")
                {
                    if (!accounts.ContainsKey(int.Parse(linia[1])))
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    else
                    {
                        int nomerSmetka = int.Parse(linia[1]);
                        double amount = double.Parse(linia[2]);
                        accounts[nomerSmetka].Deposit(amount);
                    }
                }

                //Теглене
                if (linia[0] == "Withdraw")
                {
                    if (!accounts.ContainsKey(int.Parse(linia[1])))
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    else
                    {
                        int nomerSmetka = int.Parse(linia[1]);
                        double amount = double.Parse(linia[2]);
                        accounts[nomerSmetka].Withdraw(amount);
                    }
                }

                if (linia[0] == "Print")
                {
                    if (!accounts.ContainsKey(int.Parse(linia[1])))
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    else
                    {
                        int nomerSmetka = int.Parse(linia[1]);
                        accounts[nomerSmetka].Print();
                    }
                }

                linia = Console.ReadLine().Split().ToList();
            }//end while

        }
    }
}
