using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : ICompany, IVehicle
    {
        public string ExtraSpace {  get; set; }
        public bool FoldableSeats { get; set; }
        public string Make { get ; set ; }
        public string Name { get ; set ; }
        public int NumberOfWheels { get ; set ; }
        public int NumberOfDoors { get ; set ; }
        public int NumberOfSeats { get ; set ; }

        public void GetPropeties()
        {
            Console.WriteLine($"This is a {Make} model {Name}.");
            Console.WriteLine($"It has {NumberOfWheels} wheels, {NumberOfDoors} doors and {NumberOfSeats} seats.");
            Console.WriteLine($"This model comes with extra {ExtraSpace}, you can take everyone on the journey!");

            if (FoldableSeats)
                Console.WriteLine("You can make it have more space by folding the seats!");
            else
                Console.WriteLine("This Model can´t fold the seats, you get what you see.");
            Console.WriteLine();
        }
    }
}
