using GangOf4Patterns.Creational.Builder.Model;

namespace GangOf4Patterns.Creational.Builder.Services;
public abstract class CarBuilder
{
    public Car Car { get; private set; }

    public CarBuilder(string carType)
    {
        Car = new Car(carType);
    }

    public abstract void BuildEngine();
    public abstract void BuildFrame();
}