using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_Family
{
    class Family
    {
        private  List<Person> hora = new List<Person>();

        public List<Person> Hora
        {
            get { return hora; }
            set { hora = value;}
        }

        public void Print()
        {
            foreach (var item in hora)
            {
                Console.WriteLine($"{item.Name}:{item.Age} години");
            }
        }
    }
}
