using GangOf4Patterns.Behavioural.Iterator.Models;
using GangOf4Patterns.Behavioural.Iterator.Services;
using GangOf4Patterns.Creational;

namespace GangOf4Patterns.Behavioural.Iterator;

public class RunIterator : ICreational
{
    public void Execute(string title)
    {
        Console.Title = title;

        PeopleCollection people = new();

        people.Add(new Person("Joe", "Ireland"));
        people.Add(new Person("Fred", "Ireland"));
        people.Add(new Person("Tim", "Germany"));

        var peopleIterator = people.CreateIterator();

        for (Person person = peopleIterator.First(); !peopleIterator.IsDone; person = peopleIterator.Next())
        {
            Console.WriteLine(person?.Name);
        }

        Console.ReadKey();
    }
}
