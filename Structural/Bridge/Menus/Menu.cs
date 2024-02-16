using GangOf4Patterns.Structural.Bridge.Coupons;
namespace GangOf4Patterns.Structural.Bridge.Menus;
public abstract class Menu
{
    public readonly ICoupon _coupon = null!;
    public abstract int CalculatePrice();
    public Menu(ICoupon coupon)
    {
        _coupon = coupon;
    }
}