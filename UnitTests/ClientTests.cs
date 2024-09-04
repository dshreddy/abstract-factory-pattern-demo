/******************************************************************************
 * Filename    = ClientTests.cs
 *
 * Author      = SaiHemanthReddy
 *
 * Product     = SoftwareDesignPatterns
 * 
 * Project     = UnitTests
 *
 * Description = This file contains unit tests for the Client module.
 *****************************************************************************/

using Client;
using Factories;

namespace UnitTests
{
    /// <summary>
    /// Contains unit tests for the <see cref="Client"/> classes.
    /// </summary>
    [TestClass]
    public class ClientTests
    {
        /// <summary>
        /// Tests whether the <see cref="VehicleWorld"/> correctly creates and drives a car.
        /// </summary>
        [TestMethod]
        public void VehicleWorldShouldCreateAndDriveCarCorrectly()
        {
            // Arrange
            using StringWriter sw = new();
            Console.SetOut( sw );

            // Act
            VehicleFactory factory = new CarFactory();
            VehicleWorld world = new( factory );
            world.DriveVehicle();

            // Assert
            string expected = string.Format( "Driving a Car{0}" , Environment.NewLine );
            Assert.AreEqual( expected , sw.ToString() );
        }

        /// <summary>
        /// Tests whether the <see cref="VehicleWorld"/> correctly creates and drives a bike.
        /// </summary>
        [TestMethod]
        public void VehicleWorldShouldCreateAndDriveBikeCorrectly()
        {
            // Arrange
            using StringWriter sw = new();
            Console.SetOut( sw );

            // Act
            VehicleFactory factory = new BikeFactory();
            VehicleWorld world = new( factory );
            world.DriveVehicle();

            // Assert
            string expected = string.Format( "Driving a Bike{0}" , Environment.NewLine );
            Assert.AreEqual( expected , sw.ToString() );
        }
    }
}
