using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Capsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Ivan",25);
            Console.WriteLine(p1.Name);
            //p1.Name = "Asen";
            Console.WriteLine(p1.Name);
        }
    }
}
