using GangOf4Patterns.Creational.Builder.Services;

namespace GangOf4Patterns.Creational.Builder.Model;
public class Garage
{
    private CarBuilder? _builder;

    public Garage()
    {

    }

    // very similar to abstract factory only builder constructs step-by-step
    public void Construct(CarBuilder builder)
    {
        _builder = builder;
        _builder.BuildEngine();
        _builder.BuildFrame();
    }
}