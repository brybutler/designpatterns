using GangOf4Patterns.Behavioural.Iterator.Models;

namespace GangOf4Patterns.Behavioural.Iterator.Services;
public interface IPeopleIterator
{
    Person First();
    Person Next();
    bool IsDone { get; }
    Person CurrentItem { get; }
}