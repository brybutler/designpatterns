using GangOf4Patterns.Creational;
using GangOf4Patterns.Structural.Decorator.Decorators;
using GangOf4Patterns.Structural.Decorator.Services;

namespace GangOf4Patterns.Structural.Decorator;
public class RunDecorator: ICreational
{
    public void Execute(string title)
    {
        Console.Title = title;

        var cloudMailService = new CloudMailService();
        cloudMailService.SendMail("Message 1");

        var onPremiseMailService = new OnPremiseMailService();
        onPremiseMailService.SendMail("Message 2");

        var statisticsDecorator = new StatisticsDecorator(cloudMailService);
        statisticsDecorator.SendMail("Message 3");

        var databaseDecorator = new DatabaseDecorator(onPremiseMailService);
        databaseDecorator.SendMail("Message 4");

        databaseDecorator.SendMail("Message 5");

        foreach (var message in databaseDecorator.SentMessages)
        {
            Console.WriteLine($"Stored message: {message}");   
        }

        Console.ReadKey();
    }
}

