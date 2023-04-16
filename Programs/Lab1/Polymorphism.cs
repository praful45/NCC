//7.Write a C# program how virtual method are used in polymorphism.
using System;

namespace Lab1
{

    internal class Vehicle
    {
        public virtual void Transport()
        {
            Console.WriteLine("The vehicles transports");
        }
    }

    internal class Car : Vehicle
    {
        public override void Transport()
        {
            Console.WriteLine("Car transports on road");
        }
    }

    internal class Ship: Vehicle
    {
        public override void Transport()
        {
            Console.WriteLine("Ship transports on water");
        }
    }
    internal class Polymorphism
    {

        static void Main()
        {
            Vehicle[] vehicles = new Vehicle[2];
            vehicles[0] = new Car();
            vehicles[1] = new Ship();

            foreach(Vehicle vehicle in vehicles)
            {
                vehicle.Transport();
            }
        }
    }
}
