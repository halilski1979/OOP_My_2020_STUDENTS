using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Konstruktor1
{
    class Person
    {
        private string name;
        private int age;
        private List<string> kidsName = new List<string>();


        // Всички имена по Default ще имат име "Pesho"
        // Ako обаче на обекта дадем някакво име, той ще приеме новото име

        //public Person()
        //{
        //    name = "Pesho";
        //}

        //Празен конструктор
        public Person()
        {
            //Това го пишем, ако в полето List e записано без   = new List<string>()
            //this.kidsName = kidsName ;
        }

        // Person p3 = new Person("Ivan");
        public Person(string name)
        {
            this.name = name;
            //this.kidsName = kidsName ;
        }

        // Person p4 = new Person("Ivan",25);
        public Person(string name,int age)
        {
            this.name = name;
            this.age = age;
            //this.kidsName = kidsName ;
        }


        public string Name
        {
            get { return name; }
            set { name = value;}
        }

        public int Age
        {
            get { return age; }
            set { age = value;}
        }

        public List<string> KidsName
        {
            get { return kidsName; }
            set { kidsName = value;}
        }
    }
}
