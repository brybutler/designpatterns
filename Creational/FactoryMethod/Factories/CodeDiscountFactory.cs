using GangOf4Patterns.Creational.FactoryMethod.Services;

namespace GangOf4Patterns.Creational.FactoryMethod.Factories;
public class CodeDiscountFactory : DiscountFactory
{
    private readonly Guid _code;
    public CodeDiscountFactory(Guid code)
    {
        _code = code;
    }

    public override DiscountService CreateDiscountService()
    {
        return new CodeDiscountService(_code);
    }
}