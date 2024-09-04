/******************************************************************************
 * Filename    = Bike.cs
 *
 * Author      = Sai Hemanth Reddy
 *
 * Product     = Software Design Patterns
 * 
 * Project     = Abstract Factory Pattern Demo
 *
 * Description = The 'Product1' class representing a bike.
 *****************************************************************************/

namespace Products
{
    /// <summary>
    /// Represents the 'Product1' class in the Abstract Factory pattern.
    /// Implements the vehicle-specific behavior for a bike.
    /// </summary>
    public class Bike : Vehicle
    {
        /// <summary>
        /// Drives the bike by outputting a message to the console.
        /// </summary>
        public override void Drive()
        {
            Console.WriteLine( "Driving a Bike" );
        }
    }
}
