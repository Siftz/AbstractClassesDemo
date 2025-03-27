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
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties: Year, Make, and Model
             * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion   
            
            // create a list of vehicle
            List<Vehicle> vehicles = new List<Vehicle>();
            
            // create 4 vehicle instances and init properties
            Car car1 = new Car { Year = "2022", Make = "Toyota", Model = "Camry", HasTrunk = true };
            Motorcycle moto1 = new Motorcycle { Year = "2023", Make = "Harley-Davidson", Model= "Sportster", HasSideCart =  false };
            Vehicle vehicle1 = new Car { Year = "2018", Make = "Honda", Model = "Civic", HasTrunk = false };
            Vehicle vehicle2 = new Motorcycle { Year = "2020", Make = "Ducati", Model = "Monster", HasSideCart = true };
            
            //add vehicles to list
            vehicles.Add(car1);
            vehicles.Add(moto1);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);
            
            //iterate list and display props
            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model}");
                
                //check and display unique props
                if (vehicle is Car car)
                {
                    Console.WriteLine($"Has Trunk: {car.HasTrunk}");
                }
                else if (vehicle is Motorcycle moto)
                {
                    Console.WriteLine($"Has SideCart: {moto.HasSideCart}");
                }
                Console.WriteLine(); // blank line makes it easier to read
            }
            //Call the Drive methods for a car and motorcycle
            Console.WriteLine("Testing drive methods");
            car1.DriveAbstract();
            car1.DriveVirtual();
            
            Console.WriteLine(); // blank space
            
            moto1.DriveAbstract();
            moto1.DriveVirtual();
            
            
        }
    }
}
