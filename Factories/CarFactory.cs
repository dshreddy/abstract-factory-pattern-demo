/******************************************************************************
* Filename    = CarFactory.cs
*
* Author      = Sai Hemanth Reddy
*
* Product     = Software Design Patterns
* 
* Project     = Abstract Factory Pattern Demo
*
* Description = The 'ConcreteFactory1' class
*****************************************************************************/
using Products;

namespace Factories
{
    public class CarFactory : VehicleFactory
    {
        public override Vehicle CreateVehicle()
        {
            return new Car();
        }
    }
}
