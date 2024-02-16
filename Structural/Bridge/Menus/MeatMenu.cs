using GangOf4Patterns.Structural.Bridge.Coupons;
namespace GangOf4Patterns.Structural.Bridge.Menus;
public class MeatMenu : Menu
{
    public MeatMenu(ICoupon coupon) : base(coupon) { }
    public override int CalculatePrice()
    {
        return 30 - _coupon.CouponValue;
    }
}