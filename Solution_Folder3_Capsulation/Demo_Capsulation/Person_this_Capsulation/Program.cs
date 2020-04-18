using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_this_Capsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int br = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for (int i = 0; i < br; i++)
            {
                var line = Console.ReadLine().Split();
                Person p1 = new Person(line[0],line[1],int.Parse(line[2]));
                people.Add(p1);
            }

            //people=people.OrderBy(x => x.FirstName).ThenBy(x => x.Age).ToList();

            //foreach (var item in people)
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine("===================");
            people.OrderBy(x => x.FirstName).ThenBy(x => x.Age).ToList().ForEach(x=>Console.WriteLine(x.ToString()));





        }
    }
}
