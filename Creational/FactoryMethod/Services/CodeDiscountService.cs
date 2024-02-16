namespace GangOf4Patterns.Creational.FactoryMethod.Services;
public class CodeDiscountService : DiscountService
{
    private readonly Guid _code;
    public CodeDiscountService(Guid code)
    {
        _code = code;
    }

    public override int DiscountPercentage => 15;
}