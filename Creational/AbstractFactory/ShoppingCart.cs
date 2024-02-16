using GangOf4Patterns.Creational.AbstractFactory.Factories;
using GangOf4Patterns.Creational.AbstractFactory.Services;
using GangOf4Patterns.Creational.AbstractFactory.ShippingServices;

namespace GangOf4Patterns.Creational.AbstractFactory;
public class ShoppingCart
{
    private readonly IDiscountService _discountService;
    private readonly IShippingCostsService _shippingCostsService;
    private int _orderCosts;

    //Constructor
    public ShoppingCart(IShoppingCartPurchaseFactory factory)
    {
        _discountService = factory.CreateDiscountService();
        _shippingCostsService = factory.CreateShippingCostsService();
        _orderCosts = 200;
    }

    public void CalculateCosts()
    {
        Console.WriteLine($"Total costs = {_orderCosts - (_orderCosts / 100 * _discountService.DiscountPercentage) + _shippingCostsService.ShippingCosts }");
    }
}

