public class CarShop
{
    private ICarBuilder _builder;

    public CarShop(ICarBuilder builder)
    {
        _builder = builder;
    }

    public CarPrototype BuildCar(string model, string color, int price)
    {
        _builder.SetModel(model);
        _builder.SetColor(color);
        _builder.SetPrice(price);

        return _builder.GetCar().Clone();
    }
}