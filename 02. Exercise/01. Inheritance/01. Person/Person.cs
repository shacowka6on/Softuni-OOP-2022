using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        private string name;
        private int age;
        public string Name { get { return name; } set { name = value; } }
        public virtual int Age
        { 
            get { return this.age; }
            set { if(value >= 0 ) this.age = value; }
        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(String.Format($"Name: {Name}, Age: {Age}"));
            return sb.ToString();
        }
    }
}
