using GangOf4Patterns.Creational.AbstractFactory.Services;
using GangOf4Patterns.Creational.AbstractFactory.ShippingServices;

namespace GangOf4Patterns.Creational.AbstractFactory.Factories;
public interface IShoppingCartPurchaseFactory
{
    IDiscountService CreateDiscountService();
    IShippingCostsService CreateShippingCostsService();
}