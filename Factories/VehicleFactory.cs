/******************************************************************************
* Filename    = VehicleFactory.cs
*
* Author      = Sai Hemanth Reddy
*
* Product     = Software Design Patterns
* 
* Project     = Abstract Factory Pattern Demo
*
* Description = The 'AbstractFactory' abstract class
*****************************************************************************/
using Products;

namespace Factories
{
    public abstract class VehicleFactory
    {
        public abstract Vehicle CreateVehicle();
    }
}
