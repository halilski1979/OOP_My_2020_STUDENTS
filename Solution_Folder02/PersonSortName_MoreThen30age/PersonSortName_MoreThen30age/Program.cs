using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonSortName_MoreThen30age
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("br=");
            int br = int.Parse(Console.ReadLine());
            List<Person> students = new List<Person>();
            for (int i = 0; i < br; i++)
            {
                Person p1 = new Person();
                var line = Console.ReadLine().Split(' ');
                p1.Name = line[0];
                p1.Age = int.Parse(line[1]);
                students.Add(p1);
            }

            students =students.OrderBy(x => x.Name).Where(x=>x.Age>30).ToList();
            foreach (var item in students)
            {
                Console.WriteLine($"{item.Name}: {item.Age} years");
            }
        }
    }
}
