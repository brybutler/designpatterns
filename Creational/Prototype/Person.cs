namespace GangOf4Patterns.Creational.Prototype;
public abstract class Person
{
    public abstract string Name { get; set; }
    public abstract Person Clone(bool deepCopy);
}