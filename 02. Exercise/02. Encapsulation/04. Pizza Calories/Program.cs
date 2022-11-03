using System;

namespace PizzaCalories
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = null;
            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd == "END") break;
                
                try
                {
                    string[] tokens = cmd.Split(' ');
                    string action = tokens[0];
                    if (action == "Pizza")
                    {
                        string pizzaName = tokens[1];

                        pizza = new Pizza(pizzaName);
                    }
                    else if (action == "Dough")
                    {

                        string flourType = tokens[1];
                        string bakingTechnique = tokens[2];
                        int weight = int.Parse(tokens[3]);

                        Dough dough = new Dough(flourType, bakingTechnique, weight);
                        pizza.Dough = dough;
                    }
                    else
                    {
                        string toppingType = tokens[1];
                        int weight = int.Parse(tokens[2]);

                        Topping topping = new Topping(toppingType, weight);
                        pizza.AddTopping(topping);
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    return;
                }

            }
            Console.WriteLine($"{pizza.Name} - {pizza.TotalPizzaCalories():f2} Calories.");
        }
    }
}