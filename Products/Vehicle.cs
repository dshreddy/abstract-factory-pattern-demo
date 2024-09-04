/******************************************************************************
 * Filename    = Vehicle.cs
 *
 * Author      = Sai Hemanth Reddy
 *
 * Product     = Software Design Patterns
 * 
 * Project     = Abstract Factory Pattern Demo
 *
 * Description = The 'Abstract Product' abstract class representing a vehicle.
 *****************************************************************************/

namespace Products
{
    /// <summary>
    /// Represents the 'Abstract Product' class in the Abstract Factory pattern.
    /// Defines the interface for a vehicle.
    /// </summary>
    public abstract class Vehicle
    {
        /// <summary>
        /// Abstract method to drive the vehicle.
        /// </summary>
        public abstract void Drive();
    }
}
