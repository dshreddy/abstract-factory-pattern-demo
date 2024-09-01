/******************************************************************************
* Filename    = BikeFactory.cs
*
* Author      = Sai Hemanth Reddy
*
* Product     = Software Design Patterns
* 
* Project     = Abstract Factory Pattern Demo
*
* Description = The 'ConcreteFactory2' class
*****************************************************************************/
using Products;

namespace Factories
{
    public class BikeFactory : VehicleFactory
    {
        public override Vehicle CreateVehicle()
        {
            return new Bike();
        }
    }
}
