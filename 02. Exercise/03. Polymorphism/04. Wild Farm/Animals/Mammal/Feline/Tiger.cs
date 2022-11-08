using System;
using System.Collections.Generic;
using System.Text;

namespace _04.WildFarm.Animals.Mammal.Feline
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        protected override string Breed { get; set; }
        protected override string LivingRegion { get; set; }
        protected override string Name { get; set; }
        protected override double Weight { get; set; }
        protected override int FoodEaten { get; set; }

        protected override double WeightGain => 1.00;

        public override void Eat(Food food)
        {
            if (food.GetType().Name == "Meat")
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
        => "ROAR!!!";
    }
}
