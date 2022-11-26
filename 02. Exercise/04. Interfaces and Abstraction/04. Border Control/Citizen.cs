using System;
using System.Collections.Generic;
using System.Text;

namespace _04.BorderControl
{
    public class Citizen : IID
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
        public Citizen(string name, int age, string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }
        public void CheckID(string ID)
        {
            if (Id.EndsWith(ID))
            {
                Console.WriteLine(Id);
            }
        }
    }
}
