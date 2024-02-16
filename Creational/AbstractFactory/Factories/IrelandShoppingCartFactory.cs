using GangOf4Patterns.Creational.AbstractFactory.Services;
using GangOf4Patterns.Creational.AbstractFactory.ShippingServices;

namespace GangOf4Patterns.Creational.AbstractFactory.Factories;
public class IrelandShoppingCartFactory : IShoppingCartPurchaseFactory
{
    public IDiscountService CreateDiscountService()
    {
        return new IrelandDiscountService();
    }

    public IShippingCostsService CreateShippingCostsService()
    {
        return new IrelandShippingCostsService();
    }
}