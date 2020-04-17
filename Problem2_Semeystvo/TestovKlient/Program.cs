using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestovKlient
{
    class Program
    {
        static void Main(string[] args)
        {
            var accounts = new Dictionary<int, BankAccoun>();
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
                        accounts[nomerSmetka] = new BankAccoun();
                    }
                }

                if (linia[0]=="Deposit")
                {
                    if (accounts.ContainsKey(int.Parse(linia[1])))
                    {
                        int nomerSmetka = int.Parse(linia[1]);
                        double sumaDeposit = double.Parse(linia[2]);
                        accounts[nomerSmetka].Deposit(sumaDeposit);
                    }
                    else
                    {
                        Console.WriteLine("Account does not exist");
                    }
                }

                if (linia[0]=="Withdraw")
                {
                    if (accounts.ContainsKey(int.Parse(linia[1])))
                    {
                        //int nomerSmetka = int.Parse(linia[1]);
                        //double sumaTeglene = double.Parse(linia[2]);
                        accounts[int.Parse(linia[1])].Withdraw(double.Parse(linia[2]));
                    }
                    else
                    {
                        Console.WriteLine("Account does not exist");
                    }
                }

                if (linia[0]=="Print")
                {
                    if (accounts.ContainsKey(int.Parse(linia[1])))
                    {
                        accounts[int.Parse(linia[1])].Print();
                    }
                    else
                    {
                        Console.WriteLine("Account does not exist");
                    }
                }

                linia = Console.ReadLine().Split().ToList();
            }
            
        }
    }
}
