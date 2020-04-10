using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Ivan";
            p1.Age = 25;

            BankAccount smetka1 = new BankAccount();
            smetka1.NumberID = "BG_FirstBank";
            smetka1.Balance = 1000;
            BankAccount smetka2 = new BankAccount();
            smetka2.NumberID = "BG_SecondBank";
            smetka2.Balance = 2000;
            BankAccount smetka3 = new BankAccount();
            smetka3.NumberID = "BG_ThirdBank";
            smetka3.Balance = 3000;

            p1.Akaunt.Add(smetka1);
            p1.Akaunt.Add(smetka2);
            p1.Akaunt.Add(smetka3);


            foreach (var item in p1.Akaunt)
            {
                Console.Write(item.NumberID + ": ");
                Console.WriteLine(item.Balance);
            }
            Console.WriteLine($"Obshto pari: {p1.GetBalance()}");

            //p1.Akaunt.Remove(smetka1);
            //Console.WriteLine($"Obshto pari: {p1.GetBalance()}");

            //Изтриване на сметка 3
            Console.WriteLine("======= Изтриване на сметка3 ============");
            p1.Akaunt.RemoveAt(2);
            Console.WriteLine($"Obshto pari: {p1.GetBalance()}");

            foreach (var item in p1.Akaunt)
            {
                Console.Write(item.NumberID + ": ");
                Console.WriteLine(item.Balance);
            }


            //Добавяне на пари в сметка 1
            Console.WriteLine("======= Добавяне  на 111 в сметка1 ============");
            smetka1.Deposit(111);
            Console.WriteLine($"smetka1: {smetka1.Balance} след депозит");
        }
    }
}
