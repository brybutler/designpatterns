namespace GangOf4Patterns.Creational.FactoryMethod.Services;
public class CountryDiscountService : DiscountService
{
    private readonly string _countryIdentifier;

    public CountryDiscountService(string countryIdentifier)
    {
        _countryIdentifier = countryIdentifier;
    }

    public override int DiscountPercentage
    {
        get
        {
            switch (_countryIdentifier)
            {
                case "IE":
                    return 20;
                default:
                    return 10;

            }
        }
    }
}