using GangOf4Patterns.Behavioural.Visitor.Elements;

namespace GangOf4Patterns.Behavioural.Visitor.Visitors;
public interface IVisitor
{
    void VisitCustomer(Customer customer);

    void VisitEmployee(Employee employee);
}