/******************************************************************************
 * Filename    = CarFactory.cs
 *
 * Author      = Sai Hemanth Reddy
 *
 * Product     = Software Design Patterns
 * 
 * Project     = Abstract Factory Pattern Demo
 *
 * Description = The 'ConcreteFactory1' class responsible for creating cars.
 *****************************************************************************/

using Products;

namespace Factories
{
    /// <summary>
    /// Represents the 'ConcreteFactory1' class in the Abstract Factory pattern.
    /// Responsible for creating instances of <see cref="Car"/>.
    /// </summary>
    public class CarFactory : VehicleFactory
    {
        /// <summary>
        /// Creates and returns a new instance of a <see cref="Car"/>.
        /// </summary>
        /// <returns>A new <see cref="Car"/> instance.</returns>
        public override Vehicle CreateVehicle()
        {
            return new Car();
        }
    }
}
