using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            int br = int.Parse(Console.ReadLine());

            for (int i = 0; i < br; i++)
            {
                
                try
                {
                    var line = Console.ReadLine().Split(' ').ToList();
                    var p = new Person(line[0], line[1], int.Parse(line[2]), double.Parse(line[3]));
                    people.Add(p);
                }
                catch (ArgumentException e)
                {

                    Console.WriteLine(e.Message);
                }
               

            }

            // Apply Bonus
            var bonus = double.Parse(Console.ReadLine());
            people.ForEach(person => person.IncreaseSalary(bonus));

            // Print Them All
            people.ForEach(p => Console.WriteLine(p.ToString()));




        }





        }
}
