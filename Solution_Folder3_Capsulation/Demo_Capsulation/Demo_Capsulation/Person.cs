﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Capsulation
{
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

       

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }

    }
}
