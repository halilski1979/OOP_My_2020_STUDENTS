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
            Console.Write("Въведете броя на семейството: ");
            int n = int.Parse(Console.ReadLine());

            Family ivanovi = new Family();
           

            for (int i = 0; i < n; i++)
            {
                var linia = Console.ReadLine().Split(' ').ToList();
                Person p1 = new Person();
                p1.Name = linia[0];
                p1.Age = int.Parse(linia[1]);
                ivanovi.Hora.Add(p1);
                
            }
            ivanovi.Hora = ivanovi.Hora.OrderBy(x => x.Name).Where(x => x.Age > 30).ToList();
            foreach (var item in ivanovi.Hora)
            {
                Console.WriteLine($"{item.Name}:{item.Age} years old");
            }

            ivanovi.Print();
        }
    }
}
