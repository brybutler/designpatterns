﻿namespace GangOf4Patterns.Structural.Facade.Services;
public class CustomerDiscountBaseService
{
    public double CalculateDiscountBase(int customerId)
    {
        return (customerId > 8) ? 10 : 20;
    }
}