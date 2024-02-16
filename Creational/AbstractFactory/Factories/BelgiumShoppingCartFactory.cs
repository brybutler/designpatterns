using GangOf4Patterns.Creational.AbstractFactory.Services;
using GangOf4Patterns.Creational.AbstractFactory.ShippingServices;

namespace GangOf4Patterns.Creational.AbstractFactory.Factories;
public class BelgiumShoppingCartFactory : IShoppingCartPurchaseFactory
{
    public IDiscountService CreateDiscountService()
    {
        return new BelgiumDiscountService();
    }

    public IShippingCostsService CreateShippingCostsService()
    {
        return new BelgiumShippingCostsService();
    }
}