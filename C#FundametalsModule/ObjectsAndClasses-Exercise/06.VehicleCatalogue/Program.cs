using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = String.Empty;
            List<Vehicle> vehicles = new List<Vehicle>();
            while ((command = Console.ReadLine()) != "End")
            {
                string[] inputElements = command.Split(" ").ToArray();

                Vehicle vehicle = new Vehicle(inputElements[0], inputElements[1], inputElements[2], 
                    double.Parse(inputElements[3]));

                vehicles.Add(vehicle);
            }

            string model = String.Empty;

            while ((model = Console.ReadLine()) != "Close the Catalogue")
            {
                Console.WriteLine(vehicles.FirstOrDefault(x => x.Model == model).ToString());
            }

            var cars = vehicles.FindAll(x => x.Type == "car");
            var carHorsePower = cars.Sum(c => c.HorsePower);
            var averageCarPower = carHorsePower / cars.Count;


            var trucks = vehicles.FindAll(x => x.Type == "truck");
            var truckHorsePower = trucks.Sum(t => t.HorsePower);
            var averageTruckPower = truckHorsePower / trucks.Count;

            if (cars.Count == 0)
            {
                averageCarPower = 0;
            }
            if (trucks.Count == 0)
            {
                averageTruckPower = 0;
            }

            Console.WriteLine($"Cars have average horsepower of: {averageCarPower:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTruckPower:f2}.");
            //Cars have average horsepower of: 413.33.
        }


        public class Vehicle
        {
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public double HorsePower { get; set; }

            public Vehicle(string type, string model, string color, double horsePower)
            {
                this.Type = type;
                this.Model = model;
                this.Color = color;
                this.HorsePower = horsePower;
            }

            public override string ToString()
            {
                //Type: { typeOfVehicle}
                //Model: { modelOfVehicle}
                //Color: { colorOfVehicle}
                //Horsepower: { horsepowerOfVehicle}
                StringBuilder stringBuilder = new StringBuilder();
                if (this.Type == "car")
                {
                    Console.WriteLine("Type: Car");
                }
                else
                {
                    Console.WriteLine("Type: Truck");
                }
                              
                stringBuilder.AppendLine($"Model: {this.Model}");
                stringBuilder.AppendLine($"Color: {this.Color}");
                stringBuilder.AppendLine($"Horsepower: {this.HorsePower}");
                return stringBuilder.ToString().TrimEnd();
            }
        }
    }
}
