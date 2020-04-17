using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Word_BankAccount_MethodToString
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> smetki = new List<BankAccount>();

            BankAccount smetka1 = new BankAccount();
            smetka1.Id = "Parva";
            smetka1.Balance = 1000;

            BankAccount smetka2 = new BankAccount();
            smetka2.Id = "Vtora";
            smetka2.Balance = 2000;

            smetki.Add(smetka1);
            smetki.Add(smetka2);

            Console.WriteLine("Презаписан метод ToString");
            //Презаписан метод ToString
            Console.WriteLine(smetka1);
            Console.WriteLine(smetka2);

            Console.WriteLine("Метод Print");
            //Метод Print
            smetka1.Print();
            smetka2.Print();

            Console.WriteLine("Метод Print1");
            //Метод Print1
            Console.WriteLine(smetka1.Print1());
            Console.WriteLine(smetka2.Print1());


            Console.WriteLine("=========Всички от списъка  smetki============");
            foreach (var item in smetki)
            {
                Console.WriteLine(item.ToString());
                Console.WriteLine(item.Print1());
            }



        }
    }
}
