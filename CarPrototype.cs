// Prototype pattern
public abstract class CarPrototype
{
    public string Model { get; set; }
    public string Color { get; set; }
    public int Price { get; set; }

    public abstract CarPrototype Clone();
}
