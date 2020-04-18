using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creature_Sashtestvo
{
    class Creature
    {
        private string name;
        private int age;
        private string areal;

        public Creature(string name, int age, string areal)
        {
            //Name = name;
            this.name = name;
            this.age = age;
            this.areal = areal;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Areal { get => areal; set => areal = value; }
    }
}
