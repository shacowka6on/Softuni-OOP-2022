using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Animals.Birds
{
    public class Hen : Bird
    {
        protected override double WeightGain => 0.35;
        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {

        }
        public override void Eat(Food food)
        {
            this.Weight += WeightGain * food.Quantity;
            this.FoodEaten += food.Quantity;
        }

        public override string Sound()
            => "Cluck";
    }
}
