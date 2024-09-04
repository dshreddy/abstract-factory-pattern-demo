/******************************************************************************
 * Filename    = VehicleFactory.cs
 *
 * Author      = Sai Hemanth Reddy
 *
 * Product     = Software Design Patterns
 * 
 * Project     = Abstract Factory Pattern Demo
 *
 * Description = The 'AbstractFactory' abstract class responsible for declaring the method to create vehicles.
 *****************************************************************************/

using Products;

namespace Factories
{
    /// <summary>
    /// Represents the 'AbstractFactory' class in the Abstract Factory pattern.
    /// Declares the method for creating vehicles.
    /// </summary>
    public abstract class VehicleFactory
    {
        /// <summary>
        /// Creates and returns a new instance of a <see cref="Vehicle"/>.
        /// </summary>
        /// <returns>A new <see cref="Vehicle"/> instance.</returns>
        public abstract Vehicle CreateVehicle();
    }
}
