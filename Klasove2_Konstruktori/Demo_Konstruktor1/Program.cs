using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Konstruktor1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Console.WriteLine($"{p1.Name}: {p1.Age}");

            Person p2 = new Person();
            p2.Name = "Ivan2";
            Console.WriteLine($"{p2.Name}: {p2.Age}");

            Person p3 = new Person("Ivan3");
            Console.WriteLine($"{p3.Name}: {p2.Age}");

            Person p4 = new Person("Ivan4",25);
            Console.WriteLine($"{p4.Name}: {p2.Age}");

            Console.WriteLine("==============");
            p1.KidsName.Add("kids1");
            p1.KidsName.Add("kids2");
            foreach (var item in p1.KidsName)
            {
                Console.WriteLine(item);
            }
        }
    }
}
