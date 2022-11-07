using System;
using System.Linq;

namespace _01.Vehicles
{
    public class StartUp
    {
        static void Main()
        {
            string[] carData = Console.ReadLine().Split();
            Car car = new Car(double.Parse(carData[1]), double.Parse(carData[2]));
            
            string[] truckData = Console.ReadLine().Split();
            Truck truck = new Truck(double.Parse(truckData[1]), double.Parse(truckData[2]));

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                switch (tokens[0])
                {
                    case "Drive":
                        double distance = double.Parse(tokens[2]);
                        if (tokens[1] == "Car")
                        {
                            car.Drive(distance);
                        }
                        else
                        {
                            truck.Drive(distance);
                        }
                        break;
                    default:
                        double liters = double.Parse(tokens[2]);
                        if (tokens[1] == "Car")
                        {
                            car.Refuel(liters);
                        }
                        else
                        {
                            truck.Refuel(liters);
                        }
                        break;
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}