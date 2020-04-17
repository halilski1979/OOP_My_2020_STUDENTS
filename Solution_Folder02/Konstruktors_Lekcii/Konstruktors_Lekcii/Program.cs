using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktors_Lekcii
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            List<BankAccount> smetki = new List<BankAccount>();
            Dictionary<Person, List<BankAccount>> rechnikPeople = new Dictionary<Person, List<BankAccount>>();
            Console.WriteLine("Vavedete na 1 red ime i godini");
            while (true)
            {
                var line = Console.ReadLine().Split(' ');
                if (line[0]=="end")
                {
                    break;
                }
                Person p1 = new Person();
                string name = line[0];
                int age = int.Parse(line[1]);
                p1.Name = name;
                p1.Age = age;
                Console.Write($"Koлко сметки ще има {p1.Name}: ");
                int brSmetki = int.Parse(Console.ReadLine());
                for (int i = 0; i < brSmetki; i++)
                {
                    BankAccount smetka1 = new BankAccount();
                    Console.Write($"{p1.Name}: Номер на сметка: ");
                    string nomerSmetka = Console.ReadLine();
                    smetka1.Id = nomerSmetka;
                    Console.Write($"{p1.Name}: Пари на сметка: ");
                    int pariSmetka = int.Parse(Console.ReadLine());
                    smetka1.Amount = pariSmetka;
                    smetki.Add(smetka1);
                   
                }
                rechnikPeople.Add(p1, smetki);
            }
            //smetka1.Id = "FirstBank";
            //smetka1.Amount = 1000;
            //smetki.Add(smetka1);


            foreach (var item in rechnikPeople)
            {
                Console.WriteLine($"{item.Key}. {item.Value[0]} = {item.Value[1]}");
                
               
            }
            


        }
    }
}
