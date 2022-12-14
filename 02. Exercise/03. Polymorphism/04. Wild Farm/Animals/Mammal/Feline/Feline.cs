using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Animals.Mammal.Feline
{
    public abstract class Feline : Mammal
    {
        protected abstract string Breed { get; set; }
        protected Feline(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion)
        {
            Breed = breed;
        }
        public override string ToString()
        => $"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}
