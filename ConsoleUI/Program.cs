using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

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
             * done - Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCar for Motorcycle
             * done - Provide the implementations for the abstract methods (for both sub classes)
             * done - Only in the Motorcycle class will you override the virtual drive method 
             * (ie. only in Motorcycle will you add DriveVirtual & remember to override and implement it!)
            */

            // 3. done - Create a list for/of Vehicle called vehicles

            List<Vehicle> vehicles = new List<Vehicle>();

            /* 4.
             * done - Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) 
             * but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */

            Car car1 = new Car() 
            {
                HasTrunk = true,
                Year = "2021",
                Make = "Ford",
                Model = "Focus"
            };

            Motorcycle motorcycle1 = new Motorcycle() 
            {
                HasSideCar = false,
                Year = "2022",
                Make = "Harley-Davidson",
                Model = "Fat Boy"
            };

            Vehicle vehicle1 = new Car() 
            {
                HasTrunk = true,
                Year = "2023",
                Make = "Honda",
                Model = "CRV"
            };

            Vehicle vehicle2 = new Motorcycle() 
            {
                HasSideCar = true,
                Year = "2024",
                Make = "Harley-Davidson",
                Model = "Highway King"
            };

            // 5. Add the 4 vehicles to the list
            
            vehicles.Add(car1);
            vehicles.Add(motorcycle1);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);
            
            // 6. Using a foreach loop iterate over each of the properties
             
            foreach (var vehicle in vehicles)
            {
                //Console.WriteLine(vehicle.ToString());
                Console.WriteLine($"Year: {vehicle.Year}");
                Console.WriteLine($"Make: {vehicle.Make}");
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine();
            }

            // 7. Call each of the drive methods for one car and one motorcycle

            #endregion            
            
        }
    }
}
