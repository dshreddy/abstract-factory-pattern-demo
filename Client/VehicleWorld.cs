/******************************************************************************
* Filename    = VehicleWorld.cs
*
* Author      = Sai Hemanth Reddy
*
* Product     = Software Design Patterns
* 
* Project     = Abstract Factory Pattern Demo
*
* Description = The 'Client' class 
*****************************************************************************/

using Factories;
using Products;

namespace Client
{
    public class VehicleWorld
    {
        private Vehicle _vehicle;

        // Constructor

        public VehicleWorld(VehicleFactory factory)
        {
            _vehicle = factory.CreateVehicle();
        }

        public void DriveVehicle()
        {
            _vehicle.Drive();
        }
    }
}
