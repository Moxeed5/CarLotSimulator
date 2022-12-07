using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.InteropServices;

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


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //car 1 

            



            Car car1 = new Car();

            car1.Year = 1993;

            car1.Make = "Volvo";

            car1.Model = "240";

            car1.EngineNoise = "vroom";

            car1.HonkNoise = "boop boop";

            car1.IsDriveable = false;

            Car.MakeEngineNoise(car1);

            Car.MakeHonkNoise(car1);

            //car 2

            Car car2 = new Car();

            car2.Year = 2022;
            car2.Make = "Lambo";
            car2.Model = "sport";
            car2.EngineNoise = "braaaaa";
            car2.HonkNoise = "bwop";
            car2.IsDriveable = true;

            Car.MakeEngineNoise(car2);

            Car.MakeHonkNoise(car2);

            //car 3

            Car car3 = new Car();

            car3.Year = 2001;
            car3.Make = "Toyota";
            car3.Model = "Camry";
            car3.EngineNoise = "hubahubahuba";
            car3.HonkNoise = "toot toot";
            car3.IsDriveable = false;

            Car.MakeEngineNoise(car3);

            Car.MakeHonkNoise(car3);



            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            CarLot.carList = new List<Car>() { car1, car2, car3 };

            foreach (var item in CarLot.carList)
            {
                Console.WriteLine(item.Year);
                Console.WriteLine(item.Make);
                Console.WriteLine(item.Model);
                Console.WriteLine(item.EngineNoise);
                Console.WriteLine(item.HonkNoise);
                Console.WriteLine(item.IsDriveable);

                Car.MakeEngineNoise(item);
                Car.MakeHonkNoise(item);
            }




        }
    }
}
