using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankovaSmetka
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Asen";
            p1.Age = 25;
            
            BankAccount smetka1 = new BankAccount();
            smetka1.NumberID = "BG_FirstBank";
            smetka1.Balance = 1000;
            p1.Akaunt.Add(smetka1);

            BankAccount smetka2 = new BankAccount();
            smetka2.NumberID = "BG_SecondBank";
            smetka2.Balance = 2000;
            p1.Akaunt.Add(smetka2);

            BankAccount smetka3 = new BankAccount();
            smetka3.NumberID = "BG_ThirdBank";
            smetka3.Balance = 3000;
            p1.Akaunt.Add(smetka3);

            foreach (var item in p1.Akaunt)
            {
                Console.WriteLine($"{item.NumberID}: {item.Balance}");

            }

            Console.WriteLine(p1.GetBalance());

            Console.WriteLine("Vnasqme 111 v smetka1");
            smetka1.Deposit(111);
            foreach (var item in p1.Akaunt)
            {
                Console.WriteLine($"{item.NumberID}: {item.Balance}");

            }
            Console.WriteLine(p1.GetBalance());

            //Теглене на 500 лв от smetka2
            Console.WriteLine("Teglene na 500 lv ot smetka 2");
            smetka2.Withdraw(500);
            foreach (var item in p1.Akaunt)
            {
                Console.WriteLine($"{item.NumberID}: {item.Balance}");

            }



        }
    }
}
