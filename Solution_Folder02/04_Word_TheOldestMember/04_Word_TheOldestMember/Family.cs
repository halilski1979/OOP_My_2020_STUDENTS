using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Word_TheOldestMember
{
    public class Family
    {
        private List<Person> people = new List<Person>();

        public List<Person> People
        {
            get { return people;}
            set { people = value;}
        }

        public void AddMember(Person member)
        {
            People.Add(member);
        }
        
        public void Print()
        {
            foreach (var item in People)
            {
                Console.WriteLine($"{item.Name}:{item.Age} години");
            }
        }

        
        public Person GetOldest()
        {
            return People.OrderByDescending(x => x.Age).First();
            
        }
    }
}
