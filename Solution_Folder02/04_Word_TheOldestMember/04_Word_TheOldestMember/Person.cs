using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Word_TheOldestMember
{
    public class Person
    {
        private int age;
        private string name;

        public int  Age
        {
            get { return age; }
            set { age= value; }
        }

        public string Name 
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            return $"The oldest member is {Name}: {Age} years";
        }


    }
}
