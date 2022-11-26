using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.BirthdayCelebrations
{
    public class Citizen : IBirthDay
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
        public Citizen(string name, int age, string id, string birthDay)
        {
            Name = name;
            Age = age;
            Id = id;
            BirthDate = birthDay;
        }
        public string BirthDate { get; set; }
        public string BirthYear => BirthDate.Split('/').Last();

    }
}
