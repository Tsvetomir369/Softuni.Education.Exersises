using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Catalog vehicleCatalog = new Catalog();
            vehicleCatalog.cars = new List<Car>();
            vehicleCatalog.trucks = new List<Truck>();

            while (input != "end")
            {
                string[] data = input
                    .Split("/", StringSplitOptions.RemoveEmptyEntries);

                string type = data[0];

                switch (type)
                {
                    case "Cars":
                        Car car = new Car(data[1], data[2], int.Parse(data[3]));
                        vehicleCatalog.cars.Add(car);
                        break;
                    case "Truck":
                        Truck truck = new Truck(data[1], data[2], int.Parse(data[3]));
                        vehicleCatalog.trucks.Add(truck);
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }

            if (vehicleCatalog.cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in vehicleCatalog.cars.OrderBy(c => c.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (vehicleCatalog.trucks.Count > 0)
            {
                foreach (Truck truck in vehicleCatalog.trucks.OrderBy(t => t.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
            //Cars:
            //{ Brand}: { Model} - { Horse Power} hp
            //Trucks:
            //{ Brand}: { Model} - { Weight} kg

        }
    }
}
