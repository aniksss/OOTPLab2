public class CarShopTests
{
    [Fact]
    public void BuildCar_ShouldReturnCarWithCorrectModel()
    {
        // Arrange
        var builder = new CarBuilder();
        var shop = new CarShop(builder);
        var expectedModel = "Toyota Corolla";

        // Act
        var car = shop.BuildCar(expectedModel, "Red", 20000);

        // Assert
        Assert.Equal(expectedModel, car.Model);
    }

    [Fact]
    public void BuildCar_ShouldReturnCarWithCorrectColor()
    {
        // Arrange
        var builder = new CarBuilder();
        var shop = new CarShop(builder);
        var expectedColor = "Blue";

        // Act
        var car = shop.BuildCar("Honda Civic", expectedColor, 25000);

        // Assert
        Assert.Equal(expectedColor, car.Color);
    }

    [Fact]
    public void BuildCar_ShouldReturnCarWithCorrectPrice()
    {
        // Arrange
        var builder = new CarBuilder();
        var shop = new CarShop(builder);
        var expectedPrice = 35000;

        // Act
        var car = shop.BuildCar("Nissan Altima", "Black", expectedPrice);

        // Assert
        Assert.Equal(expectedPrice, car.Price);
    }

    [Fact]
    public void BuildCar_ShouldReturnUniqueObject()
    {
        // Arrange
        var builder = new CarBuilder();
        var shop = new CarShop(builder);

        // Act
        var car1 = shop.BuildCar("Tesla Model 3", "White", 40000);
        var car2 = shop.BuildCar("Tesla Model 3", "White", 40000);

        // Assert
        Assert.NotSame(car1, car2);
    }
}