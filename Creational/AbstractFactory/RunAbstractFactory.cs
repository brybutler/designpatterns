using GangOf4Patterns.Creational.AbstractFactory.Factories;

namespace GangOf4Patterns.Creational.AbstractFactory;
public class RunAbstractFactory
{
    public void Execute()
    {
        Console.Title = "Abstract Factory";

        var belgiumShoppingCartFactory = new BelgiumShoppingCartFactory();
        var shoppingCartBe = new ShoppingCart(belgiumShoppingCartFactory);
        shoppingCartBe.CalculateCosts();

        var irelandShoppingCartFactory = new IrelandShoppingCartFactory();
        var shoppingCartIe = new ShoppingCart(irelandShoppingCartFactory);
        shoppingCartIe.CalculateCosts();
        Console.ReadKey();
    }
}

