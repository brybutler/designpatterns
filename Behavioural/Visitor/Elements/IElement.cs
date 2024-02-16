using GangOf4Patterns.Behavioural.Visitor.Visitors;

namespace GangOf4Patterns.Behavioural.Visitor.Elements;
public interface IElement
{
    void Accept(IVisitor visitor);
}