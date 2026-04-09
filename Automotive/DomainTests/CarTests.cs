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
}