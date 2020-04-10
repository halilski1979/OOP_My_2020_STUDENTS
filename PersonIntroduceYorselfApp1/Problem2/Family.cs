using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Family
    {
        private List<Person> chovek = new List<Person>();

        public List<Person> Chovek 
        {
            get { return chovek; }
            set { chovek = value; }
        }

        public void Print()
        {
            foreach (var item in Chovek)
            {
                Console.WriteLine($"Име: {item.Name}, {item.Age} години");
            }
        }
    }
}
