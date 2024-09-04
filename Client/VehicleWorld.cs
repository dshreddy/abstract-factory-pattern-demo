/******************************************************************************
 * Filename    = VehicleWorld.cs
 *
 * Author      = Sai Hemanth Reddy
 *
 * Product     = Software Design Patterns
 * 
 * Project     = Abstract Factory Pattern Demo
 *
 * Description = The 'Client' class responsible for managing and driving vehicles created by different vehicle factories.
 *****************************************************************************/

using Factories;
using Products;

namespace Client
{
    /// <summary>
    /// Represents the 'Client' class in the Abstract Factory pattern.
    /// Responsible for managing and driving vehicles created by vehicle factories.
    /// </summary>
    public class VehicleWorld
    {
        private readonly Vehicle _vehicle;

        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleWorld"/> class.
        /// </summary>
        /// <param name="factory">The factory used to create a specific type of vehicle.</param>
        public VehicleWorld( VehicleFactory factory )
        {
            _vehicle = factory.CreateVehicle();
        }

        /// <summary>
        /// Drives the vehicle created by the factory.
        /// </summary>
        public void DriveVehicle()
        {
            _vehicle.Drive();
        }
    }
}
