using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car()
            {
                HasTrunk = false,
                HasWindShield = true,
                Make = "Honda",
                Name = "Accord",
                NumberOfWheels = 4,
                NumberOfDoors = 4,
                NumberOfSeats = 5
            };

            var truck1 = new Truck()
            {
                CanItTow = true,
                ExtraSuspension = true,
                Make = "Ford",
                Name = "F-150",
                NumberOfWheels = 4,
                NumberOfDoors = 2,
                NumberOfSeats = 3
            };

            var suv1 = new SUV()
            {
                ExtraSpace = "5 seats",
                FoldableSeats = true,
                Make = "Toyota",
                Name = "RAV4",
                NumberOfWheels = 4,
                NumberOfDoors = 6,
                NumberOfSeats = 10
            };

            var cars = new List<IVehicle>() { car1, truck1, suv1 };

            foreach (var car in cars)
            {
                car.GetPropeties();
            }

        }
    }
}
