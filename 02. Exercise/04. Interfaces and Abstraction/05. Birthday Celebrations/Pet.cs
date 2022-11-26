using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.BirthdayCelebrations
{
    public class Pet : IBirthDay
    {
        public string Name { get; set; }    
        public string BirthDate { get ; set; }
        public string BirthYear => BirthDate.Split('/').Last();
        public Pet(string name, string birthDay)
        {
            Name = name;
            BirthDate = birthDay;
        }
    }
}
