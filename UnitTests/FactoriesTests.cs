/******************************************************************************
 * Filename    = FactoriesTests.cs
 *
 * Author      = Sai Hemanth Reddy
 *
 * Product     = Software Design Patterns
 * 
 * Project     = UnitTests
 *
 * Description = Contains unit tests for the vehicle factories, ensuring they correctly create instances of bikes and cars.
 *****************************************************************************/

using Factories;
using Products;

namespace UnitTests
{
    /// <summary>
    /// Contains unit tests for the vehicle factories.
    /// </summary>
    [TestClass]
    public class FactoriesTests
    {
        /// <summary>
        /// Tests whether the <see cref="BikeFactory"/> correctly creates an instance of a <see cref="Bike"/>.
        /// </summary>
        [TestMethod]
        public void BikeFactoryShouldCreateBike()
        {
            VehicleFactory factory = new BikeFactory();
            Vehicle vehicle = factory.CreateVehicle();
            Assert.IsNotNull( vehicle , "The BikeFactory did not create a Vehicle instance." );
            Assert.IsInstanceOfType( vehicle , typeof( Bike ) , "The created vehicle is not of type Bike." );
        }

        /// <summary>
        /// Tests whether the <see cref="CarFactory"/> correctly creates an instance of a <see cref="Car"/>.
        /// </summary>
        [TestMethod]
        public void CarFactoryShouldCreateCar()
        {
            VehicleFactory factory = new CarFactory();
            Vehicle vehicle = factory.CreateVehicle();
            Assert.IsNotNull( vehicle , "The CarFactory did not create a Vehicle instance." );
            Assert.IsInstanceOfType( vehicle , typeof( Car ) , "The created vehicle is not of type Car." );
        }
    }
}
