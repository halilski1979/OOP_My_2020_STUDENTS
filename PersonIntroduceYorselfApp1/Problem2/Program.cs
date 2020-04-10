using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {

            Family semeystvo = new Family();
            Console.Write("Брой хора в семейството: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var linia = Console.ReadLine().Split(' ').ToList();
                Person p1 = new Person();
                p1.Name = linia[0];
                p1.Age = int.Parse(linia[1]);
                semeystvo.Chovek.Add(p1);                     
             }

            //Сортиране по име
            semeystvo.Chovek = semeystvo.Chovek.OrderBy(x => x.Name).ToList();

            //Печат с foreach
            foreach (var item in semeystvo.Chovek)
            {
                Console.Write(item.Name+ " ");
                Console.WriteLine(item.Age);
            }


            semeystvo.Chovek.RemoveAt(1);
            //Печат с метод
            semeystvo.Print();
        }
    }
}
