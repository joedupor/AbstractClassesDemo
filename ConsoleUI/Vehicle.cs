using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {

        public string Year { get; set; } = "any year";

        public string Make { get; set; } = "any make";

        public string Model { get; set; } = "any model";

        public abstract void DriveAbstract();  //this shows method with no implementation
        

        public virtual void DriveVirtual()     //this shows method with base implementation
        {
            //Console.WriteLine();
        }




    }
}
