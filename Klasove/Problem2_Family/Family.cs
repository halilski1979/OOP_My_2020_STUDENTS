using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_Family
{
    class Family
    {
        private List<Person> people = new List<Person>();

        public List<Person> People
        {
            get { return people;}
            set { people = value; }
        }

        public void Print()
        {
            foreach (var item in people)
            {
                if (item.Age>30)
                {
                    Console.WriteLine($"{item.Name}: {item.Age} години");
                }
                
            }
        }
    }
}
