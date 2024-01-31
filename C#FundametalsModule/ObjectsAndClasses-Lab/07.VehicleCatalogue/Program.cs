using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            CatalogVehicle catalogue = new CatalogVehicle();
            catalogue.cars = new List<Car>();
            catalogue.trucks = new List<Truck>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] data = input
                    .Split("/", StringSplitOptions.RemoveEmptyEntries);
                string type = data[0];
                //string brand = data[1];
                //string model = data[2];
                //int horsePower = int.Parse(data[3]);
                //int weight = int.Parse(data[3]);

                switch (type)
                {
                    case "Car":
                        Car car = new Car(data[1], data[2], int.Parse(data[3]));
                        catalogue.cars.Add(car);
                        break;
                    case "Truck":
                        Truck truck = new Truck(data[1], data[2], int.Parse(data[3]));
                        catalogue.trucks.Add(truck);
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }

            if (catalogue.cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in catalogue.cars.OrderBy(c => c.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (catalogue.trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in catalogue.trucks.OrderBy(t => t.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
    //class Car
    //{

    //    public Car(string brand, string model, int horsePower)
    //    {
    //        this.Brand = brand;
    //        this.Model = model;
    //        this.HorsePower = horsePower;
    //    }
    //    public string Brand { get; set; }
    //    public string Model { get; set; }
    //    public int HorsePower { get; set; }
    //}
    //class Truck
    //{
    //    public Truck(string brand, string model, int weight)
    //    {
    //        this.Brand = brand;
    //        this.Model = model;
    //        this.Weight = weight;
    //    }
    //    public string Brand { get; set; }
    //    public string Model { get; set; }
    //    public int Weight { get; set; }
    //}
    //class CatalogVehicle
    //{
    //    public List<Car> cars { get; set; }
    //    public List<Truck> trucks { get; set; }

    //}
}
