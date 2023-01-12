using System;
using System.ComponentModel;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var parkinglot = new CarLot();
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars

            //Set the properties for each of the cars
            //Call each of the methods for each car
            var myCar = new Car(); // dot notation
            myCar.Make = "Hyundai";
            myCar.Model = "Kona";
            myCar.Year = 2020;
            myCar.EngineNoise = "vroom";
            myCar.HonkNoise = "beep";
            myCar.isDriveable = true;

            parkinglot.carList.Add(myCar);

            var myCar2 = new Car() //object initializer
            { Year = 2022, 
              Make = "Honda", 
              Model = "Accord", 
              EngineNoise = "rumble", 
              HonkNoise = "honk", 
              isDriveable = false };

            parkinglot.carList.Add(myCar2);

            var myCar3 = new Car(2021, "Ford", "Focus", "humm", "boop", true); { } // custom constructor

            parkinglot.carList.Add(myCar3);

            foreach(var item in parkinglot.carList)
            {
                Console.WriteLine($"Year: {item.Year}");
                Console.WriteLine($"Make: {item.Make}");
                Console.WriteLine($"Model: {item.Model}");
            }

            CarLot.numberOfCars++;
            Console.WriteLine($"Number of cars in lot: {CarLot.numberOfCars}");


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
