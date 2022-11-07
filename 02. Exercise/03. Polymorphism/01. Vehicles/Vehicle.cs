using System;


namespace _01.Vehicles
{
    public class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;

        public Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption;
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
            fuelQuantity += liters;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {fuelQuantity:f2}";
        }
    }
}