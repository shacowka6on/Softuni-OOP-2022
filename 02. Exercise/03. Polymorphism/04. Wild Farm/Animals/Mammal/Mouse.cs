using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Animals.Mammal
{
    public class Mouse : Mammal
    {
        protected override string LivingRegion { get; set; }
        protected override string Name { get; set; }
        protected override double Weight { get; set; }
        protected override int FoodEaten { get; set; }

        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }
        protected override double WeightGain => 0.10;
        public override void Eat(Food food)
        {
            if (food.GetType().Name == "Fruit" || food.GetType().Name == "Vegetable")
            {
                Weight += WeightGain * food.Quantity;
                FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
            }
        }

        public override string Sound()
            => "Squeak";
    }
}
