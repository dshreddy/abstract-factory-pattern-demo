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
    public class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            // Create and drive a car
            VehicleWorld world = new( new CarFactory() );
            world.DriveVehicle();

            // Create and drive a bike
            world = new( new BikeFactory());
            world.DriveVehicle();
        }
    }
}

