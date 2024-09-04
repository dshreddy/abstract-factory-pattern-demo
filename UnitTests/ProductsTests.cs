/******************************************************************************
 * Filename    = ProductsTests.cs
 *
 * Author      = Sai Hemanth Reddy
 *
 * Product     = Software Design Patterns
 * 
 * Project     = UnitTests
 *
 * Description = This file contains unit tests for the product classes, 
 *               specifically for the Bike and Car classes.
 *****************************************************************************/

using Products;

namespace UnitTests
{
    /// <summary>
    /// Contains unit tests for the <see cref="Products"/> classes.
    /// </summary>
    [TestClass]
    public class ProductsTests
    {
        /// <summary>
        /// Tests whether the <see cref="Bike"/> class drives correctly.
        /// </summary>
        [TestMethod]
        public void BikeShouldDriveCorrectly()
        {
            // Arrange
            using StringWriter sw = new();
            Console.SetOut( sw );

            Bike bike = new();

            // Act
            bike.Drive();

            // Assert
            string expected = string.Format( "Driving a Bike{0}" , Environment.NewLine );
            Assert.AreEqual( expected , sw.ToString() );
        }

        /// <summary>
        /// Tests whether the <see cref="Car"/> class drives correctly.
        /// </summary>
        [TestMethod]
        public void CarShouldDriveCorrectly()
        {
            // Arrange
            using StringWriter sw = new();
            Console.SetOut( sw );

            Car car = new();

            // Act
            car.Drive();

            // Assert
            string expected = string.Format( "Driving a Car{0}" , Environment.NewLine );
            Assert.AreEqual( expected , sw.ToString() );
        }
    }
}
