using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonIntroduceYorselfApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "Ivan";
            p1.Age = 25;
            //Console.WriteLine($"Name:{p1.Name}, Age:{p1.Age} ");
            Console.WriteLine(p1.IntroduceYourself());

        }
    }
}
