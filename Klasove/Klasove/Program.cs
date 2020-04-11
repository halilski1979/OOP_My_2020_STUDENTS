using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasove
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Ivan";
            p1.Age = 25;

            //Console.WriteLine($"Ime: {p1.Name} , {p1.Age} years old");

            Person p2 = new Person();
            p2.Name = "Asen";
            p2.Age = 13;
            //Console.WriteLine($"Ime: {p2.Name} , {p2.Age} years old");

            //Console.WriteLine(p1.IntroduceYourself());
            //Console.WriteLine(p2.IntroduceYourself());

            p1.I_Am();

        }
    }

   
}
