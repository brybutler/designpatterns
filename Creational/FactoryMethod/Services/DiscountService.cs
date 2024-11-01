﻿
namespace GangOf4Patterns.Creational.FactoryMethod.Services;
public abstract class DiscountService
{
    public abstract int DiscountPercentage { get; }
    public override string ToString() => GetType().Name;
}