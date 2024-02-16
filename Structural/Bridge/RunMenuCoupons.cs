using GangOf4Patterns.Creational;
using GangOf4Patterns.Structural.Bridge.Coupons;
using GangOf4Patterns.Structural.Bridge.Menus;
namespace GangOf4Patterns.Structural.Bridge;
public class RunMenuCoupons: ICreational
{
    public void Execute(string title)
    {
        Console.Title = title;
        var noCoupon = new NoCoupon();
        var oneEuroCoupon = new OneEuroCoupon();
        var twoEuroCoupon = new TwoEuroCoupon();

        var meatBasedMenu = new MeatMenu(noCoupon);
        Console.WriteLine($"Meat - no coupon: {meatBasedMenu.CalculatePrice()}");

        meatBasedMenu = new MeatMenu(oneEuroCoupon);
        Console.WriteLine($"Meat - one euro coupon: {meatBasedMenu.CalculatePrice()}");

        var vegMenu = new VegetarianMenu(twoEuroCoupon);
        Console.WriteLine($"Veg - two euro coupon: {vegMenu.CalculatePrice()}");

        Console.ReadKey();
    }
}