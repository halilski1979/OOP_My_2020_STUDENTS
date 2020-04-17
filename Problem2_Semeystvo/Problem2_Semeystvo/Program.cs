using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_Semeystvo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Брой хора в семейството: ");
            int br = int.Parse(Console.ReadLine());
            Family ivanovi = new Family();

            for (int i = 0; i < br; i++)
            {
                var linia = Console.ReadLine().Split(' ').ToList();
                Person p1 = new Person();
                p1.Name = linia[0];
                p1.Age = int.Parse(linia[1]);
                ivanovi.People.Add(p1);

            }

            //сортира списъка
            ivanovi.People = ivanovi.People.OrderBy(x => x.Name).Where(x=>x.Age>30).ToList();

            Console.WriteLine("================");
            foreach (var item in ivanovi.People)
            {
                Console.WriteLine($"Име: {item.Name},{item.Age}");
            }

            Console.WriteLine("**************");
            ivanovi.Print();
        }
    }
}
