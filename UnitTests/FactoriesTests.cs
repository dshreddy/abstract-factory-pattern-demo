using Factories;
using Products;

namespace UnitTests
{
    [TestClass]
    public class FactoriesTests
    {
        [TestMethod]
        public void BikeFactoryShouldCreateBike()
        {
            VehicleFactory factory = new BikeFactory();
            Vehicle vehicle = factory.CreateVehicle();
            Assert.IsNotNull( vehicle , "The BikeFactory did not create a Vehicle instance." );
            Assert.IsInstanceOfType( vehicle , typeof( Bike ) , "The created vehicle is not of type Bike." );
        }

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
