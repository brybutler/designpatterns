using GangOf4Patterns.Behavioural.Iterator.Models;

namespace GangOf4Patterns.Behavioural.Iterator.Services;
public class PeopleCollection : List<Person>, IPeopleCollection
{
    public IPeopleIterator CreateIterator()
    {
        return new PeopleIterator(this);
    }
}

