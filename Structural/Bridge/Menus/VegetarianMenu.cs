using GangOf4Patterns.Structural.Bridge.Coupons;
namespace GangOf4Patterns.Structural.Bridge.Menus;
public class VegetarianMenu : Menu
{
    public VegetarianMenu(ICoupon coupon) : base(coupon) { }
    public override int CalculatePrice()
    {
        return 20 - _coupon.CouponValue;
    }
}