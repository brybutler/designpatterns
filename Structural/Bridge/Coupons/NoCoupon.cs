namespace GangOf4Patterns.Structural.Bridge.Coupons;
public class NoCoupon : ICoupon
{
    public int CouponValue
    {
        get => 0;
    }
}