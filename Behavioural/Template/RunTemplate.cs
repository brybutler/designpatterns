using GangOf4Patterns.Behavioural.Template.Services;
using GangOf4Patterns.Creational;

namespace GangOf4Patterns.Behavioural.Template;
public class RunTemplate : ICreational
{
    public void Execute(string title)
    {
        Console.Title = title;
        ExchangeMailParser exchangeMailParser = new();
        Console.WriteLine(exchangeMailParser.ParseMailBody("one"));

        ApacheMailParser apacheMailParser = new();
        Console.WriteLine(apacheMailParser.ParseMailBody("two"));

        Console.ReadKey();
    }
}