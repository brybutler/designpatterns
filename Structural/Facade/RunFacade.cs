using GangOf4Patterns.Creational;
namespace GangOf4Patterns.Structural.Facade;
public class RunFacade : ICreational
{
    public void Execute(string title)
    {
        Console.Title = title;
        var facade = new DiscountFacade();

        Console.WriteLine($"Discount percent for Customer id 1: {facade.CalculateDiscountPercentage(1)}");

        Console.WriteLine($"Discount percent for Customer id 10: {facade.CalculateDiscountPercentage(10)}");

        Console.ReadKey();
    }
}