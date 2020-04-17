using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktori_Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Halil", 22);
            BankAccount smetka1 = new BankAccount();

            //Създаваме списък от банкови сметки
            List<BankAccount> smetki = new List<BankAccount>();

            smetka1.Id = "Smetka1";
            smetka1.Amount = 100;
            smetka1.Country = "Bulgaria";
            smetki.Add(smetka1);

            BankAccount smetka2 = new BankAccount();
            smetka2.Id = "Smetka2";
            smetka2.Amount = 200;
            smetka2.Country = "Bulgaria";
            smetki.Add(smetka2);
            

            foreach (var item in smetki)
            {
                Console.WriteLine($"{p1}: {item.Id}={item.Amount}, in {item.Country}");
            }

            Console.WriteLine("==========================================================");
            Person person1 = new Person("Petq",55);
            BankAccount smetka11 = new BankAccount();
            smetka11.Country = "Germany";
            smetka11.Id = "smetka11";
            smetka11.Amount = 5555;

            BankAccount smetka12 = new BankAccount();
            smetka12.Country = "Austria";
            smetka12.Id = "smetka12";
            smetka12.Amount = 4444;

            //Списъка Account вече е създаден в класа Person
            person1.Accounts.Add(smetka11);
            person1.Accounts.Add(smetka12);

            //person1.Accounts=person1.Accounts.OrderBy(x => x.Country).ToList();  Сортиране по държави в главната програма
            //person1.SortCountry();                                               Сортиране по държави с метод в class Person



            foreach (var item in person1.Accounts)
            {
                Console.WriteLine($"{person1}: [{item.Country}]=>{item.Id}={item.Amount}");
            }
            Console.WriteLine($"Общо:{person1.GetBalnce()}");
            
            

        }
    }
}
