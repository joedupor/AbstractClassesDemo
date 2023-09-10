using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("The motorcycle drives well!");
        }

        public override void DriveVirtual()     
        {
            Console.WriteLine("The motorcycle drives faster than the car!");
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Has Side Car? {HasSideCar}");
        }
    }
}
