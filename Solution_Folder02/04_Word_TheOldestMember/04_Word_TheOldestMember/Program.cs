using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Word_TheOldestMember
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //List<Family> ivanovi = new List<Family>();
            Family ivanovi = new Family();
            Console.Write("Брой членове на семейството: ");
            int br = int.Parse(Console.ReadLine());

            for (int i = 0; i < br; i++)
            {
                Person p1 = new Person();
                var line = Console.ReadLine().Split(' ').ToArray();
                p1.Name = line[0];
                p1.Age = int.Parse(line[1]);
                ivanovi.AddMember(p1);
            }

           
            ivanovi.Print();
            Console.WriteLine(ivanovi.GetOldest());
        }
    }
}
