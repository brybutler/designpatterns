
using GangOf4Patterns.Behavioural.Visitor.Elements;
using GangOf4Patterns.Behavioural.Visitor.Visitors;
using GangOf4Patterns.Creational;

namespace GangOf4Patterns.Behavioural.Visitor;

public class RunVisitor : ICreational
{
    public void Execute(string title)
    {
        Console.Title = title;

        var container = new Container();
        container.Customers.Add(new Customer("Sophie", 500));
        container.Customers.Add(new Customer("John", 10));
        container.Customers.Add(new Customer("Joe", 2000));
        container.Customers.Add(new Customer("Frank", 50));
        container.Employees.Add(new Employee("Joe",3));
        container.Employees.Add(new Employee("Jim",13));
        container.Employees.Add(new Employee("Sarah",23));


        Discount discountVisitor = new();
        container.Accept(discountVisitor);

        Console.WriteLine($"Total: {discountVisitor.TotalDiscountGiven}");

        Console.ReadKey();
    }
}
