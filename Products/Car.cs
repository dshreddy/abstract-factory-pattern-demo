/******************************************************************************
 * Filename    = Car.cs
 *
 * Author      = Sai Hemanth Reddy
 *
 * Product     = Software Design Patterns
 * 
 * Project     = Abstract Factory Pattern Demo
 *
 * Description = The 'Product2' class representing a car.
 *****************************************************************************/

namespace Products
{
    /// <summary>
    /// Represents the 'Product2' class in the Abstract Factory pattern.
    /// Implements the vehicle-specific behavior for a car.
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// Drives the car by outputting a message to the console.
        /// </summary>
        public override void Drive()
        {
            Console.WriteLine( "Driving a Car" );
        }
    }
}
