public class CarBuilder : ICarBuilder
{
    private CarPrototype _car = new Car();

    public void SetModel(string model)
    {
        _car.Model = model;
    }

    public void SetColor(string color)
    {
        _car.Color = color;
    }

    public void SetPrice(int price)
    {
        _car.Price = price;
    }

    public CarPrototype GetCar()
    {
        return _car;
    }
}