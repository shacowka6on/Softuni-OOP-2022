using System;
using System.Collections.Generic;
using _04.WildFarm.Animals;

namespace _04.WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd == "End") break;

                Animal animal = AnimalData.GetAnimal(cmd);
                Console.WriteLine(animal.Sound());

                Food food = AnimalData.GetFood(Console.ReadLine());
                animal.Eat(food);
                animals.Add(animal);
            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}
