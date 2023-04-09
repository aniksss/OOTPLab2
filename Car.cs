public class Car : CarPrototype
{
    public override CarPrototype Clone()
    {
        return (CarPrototype)this.MemberwiseClone();
    }
}