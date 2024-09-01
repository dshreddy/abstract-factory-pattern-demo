using Microsoft.VisualStudio.TestTools.UnitTesting;
using Factories;
using Main;
using System.IO;

namespace UnitTests
{
    [TestClass]
    public class MainTests
    {
        [TestMethod]
        public void ProgramShouldDriveCarCorrectly()
        {
            // Arrange
            using StringWriter sw = new();
            Console.SetOut( sw );

            VehicleFactory factory = new CarFactory();

            // Act
            Program.DriveVehicle( factory );

            // Assert
            string expected = string.Format( "Driving a Car{0}" , Environment.NewLine );
            Assert.AreEqual( expected , sw.ToString() );
        }

        [TestMethod]
        public void ProgramShouldDriveBikeCorrectly()
        {
            // Arrange
            using StringWriter sw = new();
            Console.SetOut( sw );

            VehicleFactory factory = new BikeFactory();

            // Act
            Program.DriveVehicle( factory );

            // Assert
            string expected = string.Format( "Driving a Bike{0}" , Environment.NewLine );
            Assert.AreEqual( expected , sw.ToString() );
        }
    }
}
