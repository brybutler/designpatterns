using GangOf4Patterns.Behavioural.Visitor.Visitors;

namespace GangOf4Patterns.Behavioural.Visitor.Elements;
public class Customer : IElement
{
    public decimal Amount { get; set; }
    public decimal Discount { get; set; }
    public string Name { get; set; }

    public Customer(string name, decimal amount)
    {
        Amount = amount;
        Name = name;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.VisitCustomer(this);
        Console.WriteLine($"Visited {nameof(Customer)} {Name} discount: {Discount}");
    }
}