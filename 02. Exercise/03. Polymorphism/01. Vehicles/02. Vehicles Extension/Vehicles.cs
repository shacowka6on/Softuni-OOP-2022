using System;


namespace _02.VehiclesExtension
{
    public class Vehicle
    {
        protected double fuelQuantity;
        protected double fuelConsumption;
        protected double tankCapacity;
        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption;
            if (fuelQuantity <= tankCapacity)
            {
                this.tankCapacity = tankCapacity;
            }
        }

        public virtual void Drive(double km)
        {
            double newFuelAmount = fuelQuantity - fuelConsumption * km;
            if (newFuelAmount < 0)
            {
                Console.WriteLine($"{GetType().Name} needs refueling");
            }
            else
            {
                fuelQuantity = newFuelAmount;
                Console.WriteLine($"{GetType().Name} travelled {km} km");
            }
        }

        public virtual void Refuel(double liters)
        {
            if (fuelQuantity + liters > tankCapacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            }
            else if (liters <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                fuelQuantity += liters;
            }
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {fuelQuantity:f2}";
        }
    }
}