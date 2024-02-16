using GangOf4Patterns.Creational.FactoryMethod.Services;
namespace GangOf4Patterns.Creational.FactoryMethod.Factories;
public abstract class DiscountFactory
{
    public abstract DiscountService CreateDiscountService();
}
