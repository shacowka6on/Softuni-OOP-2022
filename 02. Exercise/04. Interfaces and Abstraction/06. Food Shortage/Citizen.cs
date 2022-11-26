﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _06.FoodShortage
{
    public class Citizen : IBuyer
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
        public string BirthDate { get; set; }
        public int Food { get; set; }
        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            BirthDate = birthdate;
            Food = 0;
        }

        public void BuyFood()
        {
            Food += 10;
        }
    }
}
