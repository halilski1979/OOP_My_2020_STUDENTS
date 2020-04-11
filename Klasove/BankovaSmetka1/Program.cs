using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankovaSmetka1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Ivan";
            p1.Age = 25;

            BankAccaount smetka1 = new BankAccaount();
            smetka1.NumberID = "FirstBank";
            smetka1.Balance = 1000;
            p1.Akaunt.Add(smetka1);
            BankAccaount smetka2 = new BankAccaount();
            smetka2.NumberID = "SecondBank";
            smetka2.Balance = 2000;
            p1.Akaunt.Add(smetka2);

            Person p2 = new Person();
            p2.Name = "Asen";
            p2.Age = 33;
            
            BankAccaount asenSmetka1 = new BankAccaount();
            asenSmetka1.NumberID = "PostBank";
            asenSmetka1.Balance = 1111;
            p2.Akaunt.Add(asenSmetka1);
            BankAccaount asenSmetka2 = new BankAccaount();
            asenSmetka2.NumberID = "OBBank";
            asenSmetka2.Balance = 2222;
            p2.Akaunt.Add(asenSmetka2);

            Console.WriteLine($"{p1.Name}");
            foreach (var item in p1.Akaunt)
            {
                
                Console.WriteLine($"{item.NumberID}: {item.Balance}");
            }
            Console.WriteLine(p1.GetBalance());
            Console.WriteLine("==========");
            Console.WriteLine($"{p2.Name}");
            foreach (var item in p2.Akaunt)
            {
                Console.WriteLine($"{item.NumberID}: {item.Balance}");
            }
            Console.WriteLine(p2.GetBalance());

            //Teglene na 111 ot smetka2
            asenSmetka2.Teglene(111);
            Console.WriteLine($"{p2.Name}:{asenSmetka2.NumberID} = {asenSmetka2.Balance}");

            smetka2.Depozit(500);
            Console.WriteLine($"{p1.Name} по сметка 2 има {smetka2.Balance}");
            
        }
    }
}
