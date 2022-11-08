using System;
using System.Collections.Generic;
using _03.Raiding.Heroes;

namespace _03.Raiding
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<BaseHero> heroes = new List<BaseHero>();
            int numberOfHeroes = int.Parse(Console.ReadLine());
            while (heroes.Count < numberOfHeroes)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();
                try
                {
                    BaseHero newHero = HeroFactory.GetHero(name, type);
                    heroes.Add(newHero);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            int bossPower = int.Parse(Console.ReadLine());
            int totalPower = 0;
            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
                totalPower += hero.Power;
            }

            string outcome = totalPower >= bossPower ? "Victory!" : "Defeat...";
            Console.WriteLine(outcome);
        }
    }
}
