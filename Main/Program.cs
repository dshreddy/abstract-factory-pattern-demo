/******************************************************************************
* Filename    = Program.cs
*
* Author      = Sai Hemanth Reddy
*
* Product     = Software Design Patterns
* 
* Project     = Abstract Factory Pattern Demo
*
* Description = Startup class for Abstract Factory Design Pattern Demo.
*****************************************************************************/
using Factories;
using Client;

namespace Main
{
    class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            /// <summary>
            /// Create and drive a car
            /// </summary>
            VehicleFactory carFactory = new CarFactory();
            VehicleWorld carWorld = new(carFactory);
            carWorld.DriveVehicle();

            /// <summary>
            /// Create and drive a bike
            /// </summary>
            VehicleFactory bikeFactory = new BikeFactory();
            VehicleWorld bikeWorld = new(bikeFactory);
            bikeWorld.DriveVehicle();
        }
    }
}
