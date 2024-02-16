using GangOf4Patterns.Behavioural.Iterator.Models;

namespace GangOf4Patterns.Behavioural.Iterator.Services;
public class PeopleIterator : IPeopleIterator
{
    private PeopleCollection _peopleCollection;
    private int _current = 0;

    public PeopleIterator(PeopleCollection peopleCollection)
    {
        _peopleCollection = peopleCollection;
    }

    public bool IsDone => _current >= _peopleCollection.Count;

    public Person CurrentItem => _peopleCollection.OrderBy(_ => _.Name).ToList()[_current];

    public Person First()
    {
        _current = 0;
        return CurrentItem;
    }

    public Person Next()
    {
        _current++;
        if (!IsDone)
            return CurrentItem;

        return null;
    }

}