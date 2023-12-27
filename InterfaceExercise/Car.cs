using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : ICompany, IVehicle
    {
        public bool HasTrunk { get; set; }
        public bool HasWindShield { get; set; }
        public string Make { get ; set ; }
        public string Name { get ; set ; }
        public int NumberOfWheels { get ; set ; }
        public int NumberOfDoors { get ; set ; }
        public int NumberOfSeats { get ; set ; }

        public void GetPropeties()
        {
            Console.WriteLine($"This is a {Make} model {Name}.");
            Console.WriteLine($"It has {NumberOfWheels} wheels, {NumberOfDoors} doors and {NumberOfSeats} seats.");

            if (HasTrunk)
                Console.WriteLine("This Model comes with a trunk, perfect for all your necessities!");
            else
                Console.Write("This Model doesn´t come with a trunk. ");

            if (HasWindShield)
                Console.WriteLine("Like most cars, it comes with a windshield");
            else
                Console.WriteLine("This car it´s for the crazy people that don´t like a Windshield");
            Console.WriteLine();
        }
    }
}
