using Client;
using Factories;

namespace UnitTests
{
    [TestClass]
    public class ClientTests
    {
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
