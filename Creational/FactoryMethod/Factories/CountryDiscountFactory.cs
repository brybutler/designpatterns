using GangOf4Patterns.Creational.FactoryMethod.Services;

namespace GangOf4Patterns.Creational.FactoryMethod.Factories;
public class CountryDiscountFactory : DiscountFactory
{
    private readonly string _countryIdentifier;
    public CountryDiscountFactory(string countryIdentifier)
    {
        _countryIdentifier = countryIdentifier;
    }

    public override DiscountService CreateDiscountService()
    {
        return new CountryDiscountService(_countryIdentifier);
    }
}