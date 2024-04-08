using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate cars

            CarLot lot= new CarLot();

            Car car1 = new Car();
         
            // Set properties for each car
            car1.Year = 2025;
            car1.Make = "Toyota";
            car1.Model = "Camry";
            car1.EngineNoise = "Vroom Vroom";
            car1.HonkNoise = "Beep Beep";
            car1.IsDriveable = true;

            // Call methods for each car
            Console.WriteLine("Car 1:");
          
            car1.MakeEngineNoise(car1.EngineNoise);
            car1.MakeHonkNoise(car1.HonkNoise);
            Console.WriteLine();
            Console.WriteLine($"Number of Cars is {CarLot.NumberOfCars}");

            Car car2 = new Car();
            car2.Year = 2022;
            car2.Make = "Honda";
            car2.Model = "Accord";
            car2.EngineNoise = "Zoom Zoom";
            car2.HonkNoise = "Honk Honk";
            car2.IsDriveable = true;


            Console.WriteLine("Car 2:");

            car2.MakeEngineNoise(car2.EngineNoise);
            car2.MakeHonkNoise(car2.HonkNoise);
            
            Console.WriteLine();
            Console.WriteLine($"Number of Cars is {CarLot.NumberOfCars}");
            Console.WriteLine();

            Car car3 = new Car();

            car3.Year = 2023;
            car3.Make = "Ford";
            car3.Model = "Mustang";
            car3.EngineNoise = "Roar";
            car3.HonkNoise = "Toot Toot";
            car3.IsDriveable = true;

            Console.WriteLine("Car 3:");
          
            car3.MakeEngineNoise(car3.EngineNoise);
            car3.MakeHonkNoise(car3.HonkNoise);
            Console.WriteLine();
            Console.WriteLine($"Number of Cars is {CarLot.NumberOfCars}");

        }

    }
}
