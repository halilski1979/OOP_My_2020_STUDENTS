using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_Family
{
    class Program
    {
        static void Main(string[] args)
        {
            Family ivanovi = new Family();

            Console.Write("Broy chlenove v semeystvoto: ");
            int br = int.Parse(Console.ReadLine());

            for (int i = 0; i < br; i++)
            {
                var linia = Console.ReadLine().Split(' ').ToList();
                Person p1 = new Person();
                p1.Name = linia[0];
                p1.Age = int.Parse(linia[1]);
                ivanovi.People.Add(p1);
            }
            Console.WriteLine("==================");
            ivanovi.People = ivanovi.People.OrderBy(x=>x.Name).ToList();
            ivanovi.Print();

        }
    }
}
