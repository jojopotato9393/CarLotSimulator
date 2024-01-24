using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            CarLot cars = new CarLot();
    

            Car car1 = new Car();
            car1.Year = 2024;
            car1.Make = "Chevy";
            car1.Model = "z07";
            car1.EngineNoise = "Loud";
            car1.HonkNoise = "beep";
            car1.IsDriveable = true;
            Console.WriteLine("car1");
            car1.Engine();
            car1.Honk();
            
           

            Console.WriteLine();
            Car car2 = new Car() { Year = 2022, Make = "Toyota", Model = "Supra", EngineNoise = "raspy", HonkNoise = "boop", IsDriveable = true };
            Console.WriteLine("car2");
            car2.Engine();
            car2.Honk();
           

            Console.WriteLine();
            Car car3 = new Car()
            {
                Year = 2019,
                Make = "nissan",
                Model = "gtr",
                EngineNoise = "raspy",
                HonkNoise = null,
                IsDriveable = false
            };
            Console.WriteLine("Car2");
            car3.Engine();
            car3.Honk();
           
            Console.WriteLine();
            cars.Cars.Add(car1);
            cars.Cars.Add(car2);
            cars.Cars.Add(car3);
            foreach(Car car in cars.Cars)
            {
                Console.WriteLine($"{car.Year}");
                Console.WriteLine() ;
                Console.WriteLine($"{car.Make}");
                Console.WriteLine();
                Console.WriteLine($"{car.Model}");
                Console.WriteLine();
                Console.WriteLine(car.EngineNoise);
                Console.WriteLine();

            }

           

           

            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
