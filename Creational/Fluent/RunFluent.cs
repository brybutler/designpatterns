namespace GangOf4Patterns.Creational.Fluent;

public class RunFluent : ICreational
{

    // Fluent description: https://medium.com/@martinstm/fluent-builder-pattern-c-4ac39fafcb0b
    public void Execute(string title)
    {
        Console.Title = title;
        
        var burger1 = new BurgerBuilder()
                            .WithCheese()
                            .WithBacon()
                            .WithLettuce()
                            .Build();

        burger1.PrintOrder();

        var burger2 = new BurgerBuilder()
                            .WithCheese()
                            .WithPatties(2)
                            .WithPickles()
                            .Build();

        burger2.PrintOrder();

        Console.ReadKey();
    }
}
