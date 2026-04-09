using Domain;

namespace DomainTests;

[TestClass]
public sealed class CarTests
{
    [TestMethod]
    public void Should_create_car()
    {
        Car car = new Car();
        
        Assert.IsNotNull(car);
    }

    [TestMethod]
    public void ShouldCreateCarWithDoors()
    {
        Car car = new Car(5);
        
        Assert.AreEqual(5,car.Doors);
    }

    [TestMethod]
    public void ShouldThrowExceptionWhenCarHasNegativeDoors()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Car(-1));
    }
}