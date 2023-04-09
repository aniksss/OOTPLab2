public interface ICarBuilder
{
    void SetModel(string model);
    void SetColor(string color);
    void SetPrice(int price);
    CarPrototype GetCar();
}