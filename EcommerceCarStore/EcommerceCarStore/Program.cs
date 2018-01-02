using System;
using System.Collections.Generic;

namespace EcommerceCarStore
{
    class Program
    {
        /// <summary>
        /// Main entry for the console application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Car bmw = new Car("BMW", CarType.Convertible);
            Car mercedes = new Car("Mercedes", CarType.Sedan);
            Car audi = new Car("Audi", CarType.SportsCar);


            // Using List Methods
            List<Car> cars = new List<Car>();
            cars.Add(bmw);
            cars.Add(mercedes);
            cars.Add(audi);

            Console.WriteLine("\n Before Deleting BMW");
            foreach (Car car in cars)
            {
                Console.WriteLine($"Car:{car.Name} - Type:{car.Type}");
            }

            cars.Remove(bmw);

            Console.WriteLine("\n After Deleting BMW");
            foreach (Car car in cars)
            {
                Console.WriteLine($"Car:{car.Name} - Type:{car.Type}");
            }

            // Using Garage Methods
            Garage<Car> garage = new Garage<Car>();
            garage.Add(bmw);
            garage.Add(mercedes);
            garage.Add(audi);

            Console.WriteLine("\n Before Deleting BMW");
            foreach (Car car in cars)
            {
                Console.WriteLine($"Car:{car.Name} - Type:{car.Type}");
            }

            cars.Remove(bmw);

            Console.WriteLine("\n After Deleting BMW");
            foreach (Car car in cars)
            {
                Console.WriteLine($"Car:{car.Name} - Type:{car.Type}");
            }

            Console.ReadLine();
        }
    }
}
