using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.FoodShortage
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<IBuyer> buyerList = new List<IBuyer>();    
            for (int i = 0; i < n; i++)
            {
                //Formats
                //"<name> <age> <id> <birthdate>" for a Citizen
                //"<name> <age> <group>" for a Rebel
                string[] tokens = Console.ReadLine().Split();

                if (tokens.Length == 4)
                {
                    Citizen citizen = new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]);
                    buyerList.Add(citizen);
                }
                else
                {
                    Rebel rebel = new Rebel(tokens[0], int.Parse(tokens[1]), tokens[2]);
                    buyerList.Add(rebel);
                }
            }
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "End") break;

                IBuyer buyer = buyerList.FirstOrDefault(x => x.Name == name);
                if (buyerList.Contains(buyer))
                {
                    buyer.BuyFood();
                }
            }
            int sum = 0;
            foreach (var item in buyerList)
            {
                sum += item.Food;
            }
            Console.WriteLine(sum);
        }
    }
}
