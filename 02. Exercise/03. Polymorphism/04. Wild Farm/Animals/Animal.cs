using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Animals
{
    public abstract class Animal
    {
        protected abstract string Name { get; set; }
        protected abstract double Weight { get; set; }
        protected abstract int FoodEaten { get; set; }
        protected abstract double WeightGain { get; }
        public Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
            FoodEaten = 0;
        }
        public abstract string Sound();
        public abstract void Eat(Food food);
    }
}
