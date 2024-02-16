using GangOf4Patterns.Structural.Decorator.Services;

namespace GangOf4Patterns.Structural.Decorator.Decorators;
public class StatisticsDecorator : MailServiceDecoratorBase
{
    public StatisticsDecorator(IMailService mailService) : base(mailService)
    {

    }

    public override bool SendMail(string message)
    {
        Console.WriteLine($"Stats");
        return base.SendMail(message);
    }
}