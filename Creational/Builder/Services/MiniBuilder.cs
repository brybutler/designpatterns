namespace GangOf4Patterns.Creational.Builder.Services;
public class MiniBuilder : CarBuilder
{
    public MiniBuilder() : base("Mini")
    {
    }

    public override void BuildEngine()
    {
        Car.AddPart("Mini engine");
    }

    public override void BuildFrame()
    {
        Car.AddPart("Three door frame");
    }
}