using Products;

namespace UnitTests
{
    [TestClass]
    public class ProductsTests
    {
        [TestMethod]
        public void Bike_ShouldDriveCorrectly()
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

        [TestMethod]
        public void Car_ShouldDriveCorrectly()
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
