using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : ICompany, IVehicle
    {
        public bool CanItTow { get; set; }
        public bool ExtraSuspension { get; set; }
        public string Make { get ; set ; }
        public string Name { get ; set ; }
        public int NumberOfWheels { get ; set ; }
        public int NumberOfDoors { get ; set ; }
        public int NumberOfSeats { get ; set ; }

        public void GetPropeties()
        {
            Console.WriteLine($"This is a {Make} model {Name}.");
            Console.WriteLine($"It has {NumberOfWheels} wheels, {NumberOfDoors} doors and {NumberOfSeats} seats.");

            if (CanItTow)
                Console.WriteLine("This Model can Tow! Perfect for all your necessities!");
            else
                Console.Write("This Model doesn´t Tow, please be careful ");

            if (ExtraSuspension)
                Console.WriteLine("This truck has extra suspension! It can lift up to 1 Ton!");
            else
                Console.WriteLine("This comes with a normal suspension. How boring...");
            Console.WriteLine();
        }
    }
}
