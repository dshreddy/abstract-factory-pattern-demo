/******************************************************************************
 * Filename    = BikeFactory.cs
 *
 * Author      = Sai Hemanth Reddy
 *
 * Product     = Software Design Patterns
 * 
 * Project     = Abstract Factory Pattern Demo
 *
 * Description = The 'ConcreteFactory2' class responsible for creating bikes.
 *****************************************************************************/

using Products;

namespace Factories
{
    /// <summary>
    /// Represents the 'ConcreteFactory2' class in the Abstract Factory pattern.
    /// Responsible for creating instances of <see cref="Bike"/>.
    /// </summary>
    public class BikeFactory : VehicleFactory
    {
        /// <summary>
        /// Creates and returns a new instance of a <see cref="Bike"/>.
        /// </summary>
        /// <returns>A new <see cref="Bike"/> instance.</returns>
        public override Vehicle CreateVehicle()
        {
            return new Bike();
        }
    }
}
