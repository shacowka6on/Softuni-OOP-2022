using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Animals.Mammal
{
    public abstract class Mammal : Animal
    {
        protected abstract string LivingRegion { get; set; }
        protected Mammal(string name, double weight, string livingRegion)
            : base(name, weight)
        {
            LivingRegion = livingRegion;
        }
        public override string ToString()
           => $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";

    }
}
