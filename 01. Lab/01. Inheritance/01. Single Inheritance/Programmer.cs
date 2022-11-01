using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Inheritance
{
    public class Programmer
    {
        public decimal Salay { get; set; }
        public string Name { get; set; }
        public int HappinessLevel { get; set; }
        public Programmer()
        {
            Name = "Pesho";
        }
        public Programmer(string name) : this()
        {
            Name = name;
        }
        public Programmer(decimal salay, string name, int happinessLevel) : this(name)
        {
            Salay = salay;
            Name = name;
            HappinessLevel = happinessLevel;
        }

        public void GetPaid()
        {
            HappinessLevel += 10;
            Console.WriteLine($"Yooho");
        }
        public void CreateBugs()
        {
            Console.WriteLine($"I'm {Name} and only create bugs all day ._.");
        }
    }
}
