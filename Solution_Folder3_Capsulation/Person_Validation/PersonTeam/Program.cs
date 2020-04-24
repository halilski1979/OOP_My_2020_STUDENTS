using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Ivan","Ivanov",26,500);
            Person p2 = new Person("Asen", "Asenov", 25, 600);
            Team otbor = new Team("CSKA");


            otbor.FirstTeam.Add(p1);
            otbor.FirstTeam.Add(p2);
            
        }
    }
}
