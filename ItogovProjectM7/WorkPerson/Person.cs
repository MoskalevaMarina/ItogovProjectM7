using System;
using System.Collections.Generic;
using System.Text;

namespace ItogovProjectM7.WorkPerson
{
    abstract class Person
    {
        protected string FIO { get; set; }
        protected int age;
        public abstract int Age { get; set; }
        public Person(string fio, int age)
        {
            this.FIO = fio;
            this.age = age;
        }
        public abstract void Display();
    }
}
