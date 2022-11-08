using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Animals
{
    public abstract class Bird : Animal
    {
        protected override string Name { get; set; }
        protected override double Weight { get; set; }
        protected override int FoodEaten { get; set; }
        protected double WingSize { get; set; }
        public Bird(string name, double weight, double wingSize)
            : base(name, weight)
        {
            WingSize = wingSize;
        }
        public override string ToString()
            => $"{this.GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
    }
}
