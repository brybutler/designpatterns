using GangOf4Patterns.Behavioural.Visitor.Visitors;

namespace GangOf4Patterns.Behavioural.Visitor.Elements;
public class Employee : IElement
{
    public int YearsEmployed { get; set; }
    public decimal Discount { get; set; }
    public string Name { get; set; }

    public Employee(string name, int yearsEmployed)
    {
        Name = name;
        YearsEmployed = yearsEmployed;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.VisitEmployee(this);
        Console.WriteLine($"Visited {nameof(Employee)} {Name} discount: {Discount}");
    }
}