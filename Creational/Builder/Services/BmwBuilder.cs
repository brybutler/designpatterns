namespace GangOf4Patterns.Creational.Builder.Services;
public class BmwBuilder : CarBuilder
{
    public BmwBuilder() : base("BMW")
    {
    }

    public override void BuildEngine()
    {
        Car.AddPart("BMW engine");
    }

    public override void BuildFrame()
    {
        Car.AddPart("Five door frame");
    }
}