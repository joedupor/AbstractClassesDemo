using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /* 1.
             * done - Create an abstract class called Vehicle
             * done - The vehicle class shall have three string properties Year, Make, and Model
             * done - Set the defaults to something generic in the Vehicle class
             * done - Vehicle shall have an abstract method called DriveAbstract with no implementation
             * done - Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 2.
             * done - Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * done - Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * done - Provide the implementations for the abstract methods (for both sub classes)
             * done - Only in the Motorcycle class will you override the virtual drive method 
             * (ie. only in Motorcycle will you add DriveVirtual & remember to override it!)
            */

            // 3. done - Create a list for/of Vehicle called vehicles

            List<Vehicle> vehicles = new List<Vehicle>();

            /* 4.
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) 
             * but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */

            Car car = new Car();
            Motorcycle motorcycle = new Motorcycle();
            Vehicle vehicle1 = new Vehicle();
            Vehicle vehicle2 = new Vehicle();

            // 5. Add the 4 vehicles to the list
            
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);
            
            // 6. Using a foreach loop iterate over each of the properties
             

            // 7. Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
